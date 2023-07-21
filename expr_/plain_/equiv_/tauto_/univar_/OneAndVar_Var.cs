using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.ident
{
	/// <summary>
	/// 1&x = x
	/// </summary>
	public class OneAndVar_Var
	{
		static public bit.expr.stati.StatiI Create(bit.var.stati.Stati x)
		{

			return new nilnul.bit.expr.stati.duo._eq.Call(

						 nilnul.bit.expr.stati.duo.Min.Call(

						bit.expr.stati.no._one.Call.Singleton
						,
				
						x)
						,
						x
			);

		}

		static public bit.expr.stati.StatiI _Create_xNew(string a)
		{
			var x = bit.var.stati.NamingContext._GetOrCreate(a);

			return Create(x);

		}




	}
}
