using System.Collections.Generic;

namespace Exercice3
{
	public class Year
	{
		private List<LeapRule> _rules;

		public Year(int i)
		{
			_rules = new List<LeapRule>()
			{
				new IsDivisibleBy(400),
				new IsNotDivisibleBy100But400(),
			};
			var isLeap = true;
			foreach (var rule in _rules)
			{
				isLeap = rule.Verify(i);
				if (!isLeap) break;
			}
			IsLeap = isLeap;//(i % 400) == 0;

		}

		public bool IsLeap { get; set; }
	}
}