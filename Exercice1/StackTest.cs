using System;
using Moq;
using NFluent;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Exercice1
{
	[TestFixture]
	public class StackShould
	{
		[Test]
		public void pop_the_last_pushed_object()
		{
			object lastpushed = new object();
			var stack = new Stack();
			stack.Push(lastpushed);

			object popped = stack.Pop();

			Assert.AreEqual(lastpushed, popped);
		}

		[Test]	
		public void pop_should_throw_exception_when_no_have_pushed()
		{
			var stack = new Stack();

			Check
				.ThatCode(() => stack.Pop())
				.ThrowsAny();
		}

	}
}
