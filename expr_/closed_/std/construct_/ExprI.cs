using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.normal.construct_
{
	/// <summary>
	/// the truthtable of an expr can tell us the canonical form, which is then convertible to normal expr.
	/// so with the above, :
	/// for a call of op:Op,  and args a[i], we have tauto: Op(a[i]) = some normal expr. 
	/// from this tauto, we can have computation rule Op(A[i]) recursively = A[i] with only normal operators
	/// </summary>
	public interface ExprI
	{
	}
}
