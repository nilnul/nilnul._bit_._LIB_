using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;

namespace nilnul.bit.func.convert_.abstra.of_.sortie_
{
	static public class _NonboundX
	{
		static public nilnul.bit.FuncI2 _Op(nilnul.bit.FuncI2 func, IEnumerable<nilnul.bit.VarI1> _pars_sortie_nonConflictWithFuncVars) {

			return new Func2(
				new var.Sortie1(
					_pars_sortie_nonConflictWithFuncVars.Concat(
						func.pars.en
					)
				)
				,func.expr
			);
		}

		public static FuncI2 _Op(FuncI2 func, Sortie1 _pars_sortie_nonConflictWithFuncPars)
		{

			return _Op(func,_pars_sortie_nonConflictWithFuncPars.en);

			//throw new NotImplementedException();
		}
	}
}
