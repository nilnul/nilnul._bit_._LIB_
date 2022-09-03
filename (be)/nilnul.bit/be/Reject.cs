using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Reject
	{
		static public void Eval<T>(T val, Func<T,bool> func) {

			nilnul.bit.Reject.Eval(func(val));
		
		}

		static public void Ensure<T>(T val, Func<T, bool> func)
		{

			nilnul.bit.Reject.Eval(func(val));

		}

	}
}
