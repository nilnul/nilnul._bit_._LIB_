using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.axiom.eg
{
	public class AddCommutive
	{
		static public bit.expr.stati.StatiI Create(bit.var.stati.Stati x, bit.var.stati.Stati y)
		{

			return nilnul.bit.expr.stati.duo.Eq.Call(
					nilnul.bit.expr.stati.duo.Max.Create(x, y)
				,
					nilnul.bit.expr.stati.duo.Max.Create(y, x)

			);

		}

		static public bit.expr.stati.StatiI _Create_xNeY(string a, string  b)
		{
			var x = bit.var.stati.NamingContext.Create(a);
			var y = bit.var.stati.NamingContext.Create(b);

			return nilnul.bit.expr.stati.duo.Eq.Call(
					nilnul.bit.expr.stati.duo.Max.Create(x, y)
				,
					nilnul.bit.expr.stati.duo.Max.Create(y, x)

			);

		}


	}
}
