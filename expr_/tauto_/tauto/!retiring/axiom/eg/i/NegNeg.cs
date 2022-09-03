using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.axiom.i
{
	public class NegNeg
	{
		static public bit.expr.stati.StatiI Create(bit.var.stati.Stati x)
		{

			return nilnul.bit.expr.stati.mono.CallX.CreateNeg(
				nilnul.bit.expr.stati.mono.CallX.CreateNeg(
					x
				)

			);

		}

		static public bit.expr.stati.StatiI _Create_xNew(string a)
		{
			var x = bit.var.stati.NamingContext._GetOrCreate(a);

			return Create(x);

		}




	}
}
