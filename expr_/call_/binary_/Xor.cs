using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_
{


	public class Ne : Binary_generi
	{
		public Ne( ExprI_generi arg, ExprI_generi arg1) : base(bit.op_.binary_.Ne.Singleton, arg, arg1)
		{
		}

		public Ne(Expr_generi arg, Expr_generi arg1) : base(
			bit.op_.binary_.Ne.Singleton
			, arg, arg1)
		{
		}

		public Ne(ParameterExpression y, ParameterExpression z)
			:this(
				 new Expr_generi(y)

				 ,
				 new Expr_generi(z)
			)
		{
		}

		public Ne(ParameterExpression x, bool v):base(
			bit.op_.binary_.Ne.Singleton
			,
			x
			,
			Expression.Constant(v)
		)
		{
		}

		public Ne(ParameterExpression x, int v)
			:this(
				 x, bit.op_.of_._IntegerX.Op_ofNilOne(v)
			)
		{
		}

	}
}
