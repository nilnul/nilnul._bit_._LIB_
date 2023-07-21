using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.capsule_.nonclosed_
{

	/// <summary>
	/// eg:
	///		Sum( [x&y, x&!y, !x&y] )
	///			where [x&y, x&!y, !x&y] is <see cref="expr.StrI"/>, not <see cref="bit.IExpr"/>
	///	here	Sum( [x&y, x&!y, !x&y] ) is <see cref="expr_.ICapsule"/>, and per <see cref="bit.expr_.INonvariate"/>, it's truth table can still be listed-<see cref="capsule.to_.ICalculate"/>
	///			
	/// </summary>
	internal interface ICanonical8nonclosed:ICapsule
	{
	}
}
