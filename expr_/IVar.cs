using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.var;
using nilnul._op;
using nilnul.bit.var;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// <see cref="nameof(System.Linq.Expressions.ParameterExpression)"/>
	/// </summary>
	public interface IVar
		:nilnul.obj.expr_.typed_.generi_.IVar<bool>
		,
		bit.IExpr

	{

	}
	
}
