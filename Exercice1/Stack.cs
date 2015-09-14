using System;

namespace Exercice1
{
	public class Stack
	{
		private object _last;

		internal void Push(object lastpushed)
		{
			_last = lastpushed;
		}

		internal object Pop()
		{
			if (_last == null) throw new Exception();
			return _last;;
		}
	}
}