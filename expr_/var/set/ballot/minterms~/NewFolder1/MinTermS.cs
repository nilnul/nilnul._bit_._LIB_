using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sort
{

	public class MintermS
	{
		static public IEnumerable<bit.expr.simple.str.op.Conjunct.Call> Eval(bit.var.Set vars) {

			return 
				bit.var.set.Assignment._Enumerate(vars).Select(
					assigned => Minterm._Eval( 
						vars, assigned
				)
			);
		}


		static public IEnumerable<bit.expr.simple.str.op.Conjunct.Call> Eval(IEnumerable<bit.var.set.Assignment > assignments)
		{
			return assignments.Select(x=>Minterm.Eval(x));
		}
	}
}
