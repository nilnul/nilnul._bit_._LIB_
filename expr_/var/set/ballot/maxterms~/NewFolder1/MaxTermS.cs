using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.toset
{
	public class MaxtermS
	{
		static public IEnumerable<bit.expr.stati.simple.str.op.Disjunct.Call> Eval(bit.var.stati.str.be.Distinct.Asserted vars) {

			return 

				bit.var.toset.Assignments.Enumerate(vars).Select(
					assigned => Maxterm._Eval( 
						vars.val, assigned
				)
				

			);

			//return 

			//	bit.var.toset.Assignments.Enumerate(vars).Select(
			//		assigned => Maxterm.Eval( 
			//			new var.toset.Assignment(vars, assigned)
			//	)
				

			//);


		}
	}
}
