using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;
using S = nilnul.bit.var.sortie_.List;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit
{
	[Obsolete()]

	public class Func1:FuncI1
	{
		private ExprI1 _expr;

		public ExprI1 expr
		{
			get
			{
				return _expr;
				throw new NotImplementedException();
			}
		}

		private S _vars;

		public S vars
		{
			get
			{
				return _vars;
				throw new NotImplementedException();
			}
		}
		public Func1(nilnul.bit.var.sortie_.List vars, nilnul.bit.ExprI1 expr)
		{
			_vars = vars;
			_expr = expr;
		}



		public override string ToString()
		{
			return $"{_vars}{nilnul.obj._func_.GoesToSymbol.DEFAULT}{_expr}";
		}

		static public Func1 CreateFroExpr(E expr) {
			return new Func1(new S(), expr);
		}
	}
}
