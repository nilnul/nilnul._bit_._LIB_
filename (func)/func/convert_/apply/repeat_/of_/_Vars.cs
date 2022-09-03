using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_.apply.repeat_.of_
{
	static public class _VarsX
	{
		static public nilnul.bit.FuncI2 Op(nilnul.bit.FuncI2 func, IEnumerable<nilnul.bit.VarI1> vars) {
			return _RepeatX.Op(
				func
				,
				vars.Select(v => new nilnul.bit.expr_.plain_.Var(v))
			);
		}
	}
}
