using nilnul.bit.expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_.repar_
{
	static public class _OfNewX
	{
		static public nilnul.bit.FuncI2 Op(nilnul.bit.FuncI2 func,nilnul.bit.VarI1 oldPar ) {

			var newPar = new nilnul.bit.Var2();

			var newPars = func.pars.en.ToList();

			newPars[newPars.FindIndex(x => nilnul.bit.var.Eq.Singleton.Equals(x, oldPar))] = newPar;

			return new nilnul.bit.Func2(
				new var.Sortie1(newPars)
				,
				func.expr.Substitute(oldPar, newPar)
			);
		}
	}
}
