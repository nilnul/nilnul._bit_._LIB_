using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_.common_
{
	/// <summary>
	/// sum of prod, or prod of sum.
	/// analog to math:
	///		(a+b)(c-d) = (a+b)c+ (a+b)(-d)  =ac+a(-d)+bc+b(-d).
	///		if we analog "+" to logical operator "|", "*" to "&", "-" to "!"
	///		the left is pos, the right is sop. the middle is common, but not norm as it's neither sop nor pos.
	/// </summary>
	public interface INormal
	{
	}
}
