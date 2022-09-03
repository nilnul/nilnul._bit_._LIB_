using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.trio.op
{
	public class Fork
		: nilnul.trio.OpI<bool>
	{

		static public T Eval<T>(bool condition, T ifOne, T ifZero)
		{

			return condition ? ifOne : ifZero;

		}


		public bool eval(bool p, bool p1, bool p2)
		{
			return p ? p1 : p2;

			throw new NotImplementedException();
		}
	}
}
