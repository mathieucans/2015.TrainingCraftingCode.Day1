using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Exercice3
{
	[TestFixture]
	public class YearShould
	{	
		[Test]
		public void BeLeapIfIsDivisbleBy400()
		{
			Assert.IsTrue(IsLeapYear(400));
			Assert.IsTrue(IsLeapYear(800));
		}

		[Test]
		public void IsNotLeapWhenDivisiableBy100ButNotBy400()
		{
			var year = new Year(100);
			Assert.IsFalse(year.IsLeap);
			year = new Year(200);
			Assert.IsFalse(year.IsLeap);
		}

		private bool IsLeapYear(int i)
		{
			return new Year(i).IsLeap;
		}

		public void IsLeapWhenDivisibleBy4()
		{
		}
		
	}

	public class IsDivisibleBy : LeapRule
	{
		private int _denominator;

		public IsDivisibleBy(int denominator)
		{
			_denominator = denominator;
		}

		public override bool Verify(int year)
		{
			return (year%_denominator) == 0;
		}
	}

	public abstract class LeapRule
	{
		public abstract bool Verify(int i);
	}
}
