using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Reject
	{
		static public void Eval<T>(T val, Func<T,bool> func) {

			nilnul.bit.Assertion.False(func(val));
		
		}
	}
}
