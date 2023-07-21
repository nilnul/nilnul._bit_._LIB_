using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// <see cref="nameof(System.Linq.Expressions.MethodCallExpression)"/>
	/// this is the second clause of the three clauses for the recursive definition of Expr.
	/// We then have nilary,unary,  binary calls. We don't have ternary or more-ary calls for the finite defintion of expr.
	/// call is about arity and operator, doesnot constrain the inputs, which can be any <see cref="bit.IExpr"/>
	/// </summary>
	/// <remarks>
	/// the input is <see cref="nilnul.bit.IExpr"/>; so <see cref="ICall"/> is not closed, and the input <see cref="nilnul.bit.IExpr"/> can be noncall, such as:
	///		 <see cref="bit.expr_.IVar"/> is not regarded as call here,
	///		 and some <see cref="nilnul.bit.IExpr"/> can be wrapping some nonbit inputs.
	/// </remarks>
	/// alias:
	///		oped
	///		call
	public interface ICall
		:bit.IExpr
		,
		bit.expr.ICalc
	{
	}



}
