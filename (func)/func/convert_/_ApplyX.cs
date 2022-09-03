using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;//.ExprI3;

namespace nilnul.bit.func.convert_
{
	/// <summary>
	/// To correspond to the convert_.Vary, which append a var, the Apply remove that last var.
	/// </summary>
	/// <remarks>
	/// 消元
	/// </remarks>
	static public class _ApplyX
	{

		static public FuncI2 Op(FuncI2 func, E arg)
		{

			if ( ! func.pars.en.Any())	/// the last var is assumed a var of void, which has no instance in expr.
			{
				return func;
			}

			return new Func2(
				nilnul.bit.var.sortie_.sown._DeheadX._Dehead(func.pars)
				,
				func.expr.substitute(func.pars.en.First(), arg)
			);


			//throw new NotImplementedException();
		}

		

		
	}
}
