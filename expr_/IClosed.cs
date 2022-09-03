using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// all vars are of type bool.
	/// 
	///  the sub expr are only bit expr (the vars are only bit.var).
	/// We convert var into expr_.Var. (so this is not only expr_.Call)
	/// the op are finitary, such as op_.nary, op_.unary, op_.binary, op_.ternary
	///		also, binary.accumulator, is derived from biOp, and thus can be converted back to biOps.
	///		also, ternary, or N-ary op can be expressed by binary/unary/nary ops.
	/// </summary>
	/// <remarks>
	/// for example, in electronics, each component is processing binary digit. Even component can be compounded to form a bigger component, the whole board is closed 
	/// </remarks>
	public interface IClosed:nilnul.bit.expr_.rejoinder_.IClosed
	{
	}
}
