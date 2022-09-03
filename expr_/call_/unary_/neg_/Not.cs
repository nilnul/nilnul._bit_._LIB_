using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.unary_
{

	[Obsolete()]
	public interface NotI : UnaryI1
	{

	}

	[Obsolete()]
	public class Not :
		Unary2,


		NotI
	{

		public Not( ExprI3 x) : base(nilnul.bit.op_.unary_.Not1.Singleton, x)
		{
		}

		public Not(VarI1 a2):this(new nilnul.bit.expr_.Var1(a2) )
		{
		}
	}


}
