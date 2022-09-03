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
	/// </summary>
	public interface ICall:bit.IExpr
	{
	}
}
