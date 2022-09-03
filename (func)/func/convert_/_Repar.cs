using nilnul.bit.expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.func.convert_
{
	static public class _ReparX
	{
		static public nilnul.bit.FuncI2 Op(
			this
			nilnul.bit.FuncI2 func
			, 
			nilnul.bit.VarI1 oldPar
			, 
			nilnul.bit.VarI1 newPar
		) {
			if (func.pars.contain(oldPar))
			{
				if (nilnul.bit.var.Eq.Singleton.Equals(newPar,oldPar))
				{
					return func;
				}

				if (func.pars.contain(newPar) )
				{
					throw new _repar.ParConflictException( $@"{newPar} conflicts with bound." );
				}
				if ( func.expr.vars.Contains(newPar))
				{
					throw new _repar.ParConflictException( $@"{newPar} conflicts with unbound." );
				}

				var newPars = func.pars.en.ToList();

				newPars[newPars.FindIndex(x => nilnul.bit.var.Eq.Singleton.Equals(x, oldPar))] = newPar;


				return new nilnul.bit.Func2(
					new var.Sortie1(newPars)
					,

					func.expr.Substitute(oldPar, newPar)

					//
				);					

			}
			return func;
		}
	}
}
