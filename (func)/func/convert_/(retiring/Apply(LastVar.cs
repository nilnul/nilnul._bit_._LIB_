using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.func.convert_
{
	/// <summary>
	/// To correspond to the convert_.Vary, which append a var, the Apply remove that last var.
	/// </summary>
	/// 
	[Obsolete()]
	public class Apply: ConvertI
	{

		private nilnul.bit.ExprI1 _expr;

		public nilnul.bit.ExprI1 expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Apply(
			nilnul.bit.ExprI1 expr
			
		)
		{
			_expr = expr;
		}
		public FuncI1 eval(FuncI1 arg)
		{

			if ( ! arg.vars.Any())	/// the last var is assumed a var of void, which has no instance in expr.
			{
				return arg;
			}

			var lastVar = arg.vars.Last();

			return new Func1(
				
				arg.vars.cloneAndRemoveLast()
				,
				arg.expr.substitute(lastVar, _expr)
			);


			throw new NotImplementedException();
		}

		static public FuncI1 Eval(FuncI1 func, E expr) {

		
			if ( ! func.vars.Any())	/// the last var is assumed a var of void, which has no instance in expr.
			{
				return func;
			}

			var lastVar = func.vars.Last();

			return new Func1(
				
				func.vars.cloneAndRemoveLast()
				,
				func.expr.substitute(lastVar, expr)
			);	

		}

		static public FuncI1 Eval(FuncI1 func, params E[] exprs) {

			var applied = func;

			foreach (var item in exprs)
			{
				applied=Eval(applied, item);
			}
			return applied;

		

		}


	}
}
