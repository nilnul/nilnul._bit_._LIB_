using nilnul.bit._expr.untyped.be.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	[Obsolete(nameof(bit.ExprI_generi))]
	public interface ExprI_sys {
		nilnul.bit._expr.untyped.be.vow.Ee sys { get; }
	}
	[Obsolete(nameof(bit.ExprI_generi))]
	public class Expr_sys : bit._expr.untyped.be.vow.Ee
		,
		_expr_.VarsI_sys
		,ExprI_sys
	{
		public Expr_sys(Expression val) : base(val)
		{
		}
		public expr_.var.Set vars {
			get {

				var visitor = new expr._vars.Visitor();
				visitor.Visit(this);
				return visitor.vars;

			}

	}

		public Ee sys => this;
	}
}
