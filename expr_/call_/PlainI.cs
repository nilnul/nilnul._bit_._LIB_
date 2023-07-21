using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// using nothing  but plain ops.<see cref="nameof(op_.PlainI)"/>. including var.
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <alias>
	/// var, nary/unary/binary call. not many. few
	/// 
	/// </alias>
	/// 
	public interface PlainI:_plain_.VarsI,_plain_.SubstituteI
	{
	}

	public abstract class PlainA
	{
		//static public PlainI Coerce(ExprI1 expr) {
		//	switch (expr)
		//	{
		//		case expr_.VarAsExpr var:
		//			return new plain_.Var(var.var);
		//			break;
		//		case expr_.call_.No nary:
		//			return new plain_.call_.Nary(nary.op.result);
		//			break;
		//		case expr_.call_.Mono unary:
		//			return new plain_.call_.Unary(unary.op,unary.arg);
		//		default:
		//			break;
		//	}

		//}
	}
}
