using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.axiom.i.eq
{
	public class OneOrVar_One
	{
		static public bit.expr.stati.StatiI Create(bit.var.stati.Stati x)
		{

			return new nilnul.bit.expr.stati.duo._eq.Call(

						new nilnul.bit.expr.stati.duo._max.Call(

						bit.expr.stati.no._one.Call.Singleton
						,
				
						x)
						,
						nilnul.bit.expr.stati.no._one.Call.Singleton
			);

		}

		static public bit.expr.stati.StatiI _Create_xNew(string a)
		{
			var x = bit.var.stati.NamingContext._GetOrCreate(a);

			return Create(x);

		}




	}
}
