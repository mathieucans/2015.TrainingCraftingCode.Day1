namespace Exercice3
{
	public class IsNotDivisibleBy : LeapRule
	{
		private int _denominator;

		public IsNotDivisibleBy(int i)
		{
			_denominator = i;
		}

		public override bool Verify(int year)
		{
			return (year % _denominator) != 0;
		}
	}
}