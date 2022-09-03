using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.axiom.i.eq
{
	public class ZeroOrVar_Var
	{
		static public bit.expr.stati.StatiI Create(bit.var.stati.Stati x)
		{

			return new nilnul.bit.expr.stati.duo._eq.Call(



						 nilnul.bit.expr.stati.duo.Max.Call(

						false
						,
				
						x)
						,
						false


			);

		}

		static public bit.expr.stati.StatiI _Create_xNew(string a)
		{
			var x = bit.var.stati.NamingContext._GetOrCreate(a);

			return Create(x);

		}




	}
}
