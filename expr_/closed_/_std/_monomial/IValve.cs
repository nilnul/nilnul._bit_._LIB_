using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_._std._monomial
{
	/// <summary>
	/// for a var such as x:
	///		x
	///		,or,
	///		!x
	///	when used in max0minTerm
	/// </summary>
	/// <remarks>
	/// x can be regarded as i(x), where i is <see cref=" bit.op_.unary_.Nop"/>
	/// !x can be regarded as !(x)
	/// So here we introduced two <see cref="bit.op_.UnaryI1"/>, and later we would introduce &, or the two binary op;
	/// </remarks>
	/// alias:
	///		flopflip
	///		obverse
	///		flip
	///		toss, like term
	///		valve,
	///			var or veto
	///		toss
	///	<seealso cref="expr_.var.IAssign"/>
	public interface IValve
		:IClosed
	{
	}
}
