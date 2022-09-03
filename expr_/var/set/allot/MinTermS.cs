using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	public class MintermS
	{
		static public IEnumerable<bit.expr.simple.set.op.Conjunct.Call> Eval(bit.var.Set vars) {

			return 

				bit.var.set.Assignment._Enumerate(vars).Select(
					assigned => Minterm._Eval( 
						vars, assigned
				)
				

			);

			return 

				bit.var.set.Assignment._Enumerate(vars).Select(
					assigned => Minterm.Eval( 
						 var.set.Assignment._Create__sameCount(vars, assigned)
				)
				

			);


		}


		static public IEnumerable<bit.expr.simple.set.op.Conjunct.Call> Eval(IEnumerable<bit.var.set.Assignment > assignments)
		{
			return assignments.Select(x=>Minterm.Eval(x));

		}


	}
}
