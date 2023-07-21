using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_.eq_.tauto_
{
	/// <summary>
	/// some vars are output pin/poleS
	/// this is the abstraction of electronic component/gate, such as Or,And, etc
	/// </summary>
	/// <remarks>
	/// alias:
	///		gate
	///		outVar
	/// </remarks>
	public class Gate
	{
		public expr_.Var_sys var;
		public Expr_sys expr;
	}
}
