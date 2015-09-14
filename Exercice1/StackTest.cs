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
		public void pop_two_elements_in_reverse_order_that_they_have_been_pushed()
		{
			var firstObject = new Object();
			var secondObject = new Object();
			var stack = new Stack();

			stack.Push(firstObject);
			stack.Push(secondObject);

			Check.That(stack.Pop()).Equals(secondObject);
			Check.That(stack.Pop()).Equals(firstObject);
		}


		[Test]	
		public void throw_emptyexception_when_pop_and_have_pushed_nothing()
		{
			var stack = new Stack();

			Check
				.ThatCode(() => stack.Pop())
				.Throws<EmptyException>();
		}

		[Test]
		public void throw_empty_exception_when_pop_twice_after_only_one_push()
		{
			var stack = new Stack();
			stack.Push(new Object());

			stack.Pop();

			Check
				.ThatCode(() => stack.Pop())
				.Throws<EmptyException>();
		}

	}
}
