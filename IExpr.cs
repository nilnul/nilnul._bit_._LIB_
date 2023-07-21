using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;

namespace nilnul.bit
{

	/// <summary>
	/// <see cref="nameof(System.Linq.Expressions.Expression)"/>, excluding lambda (which includes Expression{TFuunc})
	/// with bit.var or vars of any type as input, output bit.
	/// </summary>
	public interface IExpr
		:nilnul.obj.IExpr<bool>
		
	{

	}

	




}
