using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;
using Sortie = nilnul.bit.var.sortie_.List;
using E = nilnul.bit.expr_.PlainI;//.ExprI3;

namespace nilnul.bit
{
	public class Func2:FuncI2
	{


		public Func2(nilnul.bit.var.Sortie1 vars, nilnul.bit.expr_.PlainI expr)
		{
			_pars = vars;
			_expr = expr;
		}

		private E _expr;

		public E expr
		{
			get
			{
				return _expr;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// for x1=>x=>expr, the pars is (x1,x). 'cuz the application f(1,2) = f(1)(2）. for f(1)(2),  in convention, 1 will go to x1, 2 will go to x
		/// </summary>
		private Sortie1 _pars;

		public Sortie1 pars
		{
			get
			{
				return _pars;
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return $"{_pars}{nilnul.obj._func_.GoesToSymbol.DEFAULT}{_expr}";
		}

		static public Func2 Create(E expr) {
			return new Func2(new Sortie1(), expr);
		}

	}
}
