using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.convert_
{
	[Obsolete()]
	public class ApplyVar : ConvertI
	{
		private nilnul.bit.VarI1  _var;

		public nilnul.bit.VarI1  var
		{
			get { return _var; }
			set { _var = value; }
		}

		private nilnul.bit.ExprI1 _expr;

		public nilnul.bit.ExprI1 expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public ApplyVar(
			nilnul.bit.VarI1 var,
			nilnul.bit.ExprI1 expr
			
		)
		{
			_var = var;
			_expr = expr;
		}
		public FuncI1 eval(FuncI1 arg)
		{

			if (!arg.vars.contain(_var))    /// the last var is assumed a var of void, which has no instance in expr.
			{
				return arg;
			}


			return new Func1(

				arg.vars.cloneAndRemove(_var)
				,
				arg.expr.substitute(_var, _expr)
			);



			//throw new NotImplementedException();
		}
	}
}
