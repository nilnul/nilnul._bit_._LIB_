using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.toset
{
	public class MintermS
	{
		static public IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> Eval(bit.var.stati.str.be.Distinct.Asserted vars) {

			return 

				bit.var.toset.Assignments.Enumerate(vars).Select(
					assigned => Minterm._Eval( 
						vars.val, assigned
				)
				

			);

			return 

				bit.var.toset.Assignments.Enumerate(vars).Select(
					assigned => Minterm.Eval( 
						new var.toset.Assignment(vars, assigned)
				)
				

			);


		}


		static public IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> Eval(IEnumerable<bit.var.toset.Assignment > assignments)
		{
			return assignments.Select(x=>Minterm.Eval(x));

		}


	}
}
