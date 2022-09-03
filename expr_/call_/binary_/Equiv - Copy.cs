using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_.unary_;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.binary_
{
	public class Eq_generi : Binary_generi

	{
		public Eq_generi(Expr_generi arg, Expr_generi arg1) : base(bit.op_.binary_.Eq.Singleton, arg, arg1)
		{
		}
		

		public Eq_generi( ExprI_generi arg, ExprI_generi arg1) : base(bit.op_.binary_.Eq.Singleton, arg, arg1)
		{
		}

		public Eq_generi(ParameterExpression x, ExprI_generi ne):this(
			new Expr_generi(x),ne
		)
		{
		}

		public Eq_generi(ParameterExpression x, ParameterExpression y)
			:this(
				 x
				 ,
				 new Expr_generi(y)
			)
		{
		}

		
	}
}
