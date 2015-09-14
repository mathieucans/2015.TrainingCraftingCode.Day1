namespace Exercice3
{
	public class IsNotDivisibleBy100But400 : LeapRule
	{
		public override bool Verify(int year)
		{
			return (year % 100) != 0 || (year % 400) == 0;
		}
	}
}