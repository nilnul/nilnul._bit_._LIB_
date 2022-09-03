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


	[Obsolete()]
	public class Not1 :
		Unary_sys
		

	{


		public Not1(ExprI_sys x) : base(nilnul.bit.op_.unary_.Not1.Singleton, x)
		{
		}
		public Not1(nilnul.bit.expr_.Var_sys a2) : this((ExprI_sys)a2)
		{
		}

		
	}


}
