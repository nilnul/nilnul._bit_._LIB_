using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_.std_._prod
{
	/// <summary>
	/// eg:
	///		x|!y
	///	eg:
	///		x
	///	eg:
	///		prod()
	///		
	/// </summary>
	/// <remarks>
	/// given vars
	///		,we can use M[0], M[1], ... to denote the maxterm.
	///	note here we regard maxterm as <see cref="nilnul.bit.IExpr"/>, and the struc of str of vars are capsuled into a black box; hence we can say, maxterm is <see cref="expr_.IClosed"/>, and moreover, <see cref="IStd"/> is closed;
	///		if we don't let this inherit <see cref="IClosed"/>, then <see cref="IStd"/> is not <see cref="IClosed"/>
	///
	/// use M[0], M[1], ... to denote this;
	/// </remarks>
	/// <see cref="expr_.var.set.IMaxterm"/>
	/// 
	internal class IMaxterm
		:IClosed
	{
	}
}
