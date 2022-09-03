using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.binary_
{
	public class Or1 : Binary_generi

	{
		

		public Or1( ExprI_generi arg, ExprI_generi arg1) : base(bit.op_.binary_.Max.Singleton, arg, arg1)
		{
		}
		public Or1(Expr_generi arg, Expr_generi arg1) : this( (ExprI_generi) arg, arg1)
		{
		}

		public Or1(ParameterExpression x, ExprI_generi ne):this(
			new Expr_generi(x),ne
		)
		{
		}

		public Or1(ParameterExpression x, ParameterExpression y)
			:this(
				 x
				 ,
				 new Expr_generi(y)
			)
		{
		}

		public Or1(ExprO e, ParameterExpression y):this(
			e
				 ,
				 new Expr_generi(y)

		)
		{
		}
	}
}
