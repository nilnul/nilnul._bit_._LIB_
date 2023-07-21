using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_
{
	/// is this <see cref="capsule_.IClosed"/>?
	/// the ans depends on whether we view strOfVar as out of the closure.
	/// if we blackbox, or tug some interim struc in capsule, we may think it is closed.
	/// if we think empty str cannot be straightforwardly converted to a closed expr, we may think it's nonclosed;
	///
	/// to avoid the indefinite discussion, let's put it here at this moment;
	/// 
	/// <summary>
	/// sum of minterms
	/// product of maxterms
	/// 
	/// eg:
	///		xyz | !z
	///	eg:
	///		sum()
	///	eg:
	///		sum
	/// </summary>
	/// <remarks>
	/// analog to math:
	///		(a+b)(c-d) = (a+b)c+ (a+b)(-d)  =ac+a(-d)+bc+b(-d).
	///		if we analog "+" to logical operator "|", "*" to "&", "-" to "!"
	///		the left is pos, the right is sop. the middle is common, but not norm as it's neither sop nor pos.
	/// 
	/// note: unlike <see cref="ICanonic"/>, std doesnot require the monomials of the same set of vars;
	///
	/// as long as we don't let the strOfValves inherit <see cref="IClosed"/>
	/// </remarks>
	/// alias:
	///		std
	///		normal
	/// 
	public interface IStd:IClosed
	{
	}


}
