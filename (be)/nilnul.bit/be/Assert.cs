using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assert
	{
		static public void Eval<T>(T val, Func<T,bool> func) {

			nilnul.bit.Assert.Eval(func(val));
		
		}

		static public T Ensure<T>(T val, Func<T,bool> func) {
			Eval(val, func);
			return val;
		
		}

		static public void Eval_dual<T>(T val, Func<T, bool> func) {
			Eval(val, x => !func(x));
		
		}
	}
}
