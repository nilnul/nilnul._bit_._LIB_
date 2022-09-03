using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.func
{
	public partial class Dual
	{
		static public Func<T, bool> Eval<T>(Func<T,bool> func) {
			return x => !func(x);
		}
	}
}
