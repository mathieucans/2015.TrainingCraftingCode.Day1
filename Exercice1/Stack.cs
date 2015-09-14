using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice1
{
	public class Stack
	{
		private readonly List<object> _stacks = new List<object>();

		internal void Push(object lastpushed)
		{
			_stacks.Add(lastpushed);
		}

		internal object Pop()
		{
			if (_stacks.Count == 0) throw new EmptyException();
			var result = _stacks.Last();
			_stacks.Remove(result);
			return result;
		}
	}
}