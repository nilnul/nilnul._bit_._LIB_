using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	public class MaxtermS
	{
		static public IEnumerable<bit.expr.simple.set.op.Disjunct.Call> Eval(bit.var.Set vars) {

			return 

				bit.var.set.Assignment._Enumerate(vars).Select(
					assigned => Maxterm._Eval( 
						vars, assigned
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
