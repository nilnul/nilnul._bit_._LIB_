using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.unary_
{


	public class Not2 :
		Unary3
		

	{


		public Not2(bit.ExprI_generi x) : base(

			nilnul.bit.op_.unary_.Not1.Singleton

			,

			x)
		{
		}
		public Not2(ParameterExpression x):base(
			nilnul.bit.op_.unary_.Not1.Singleton

			,

			x)
		{
		}
		public Not2(nilnul.bit.expr_.Var2 a2) : this((ExprI_generi)a2)
		{
		}

	}


}
