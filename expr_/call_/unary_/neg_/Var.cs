using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.unary_.neg_
{
	[Obsolete()]
	public class Var : 
		nilnul.obj.Box<nilnul.bit.VarI1>
		,
		NegI, SimpleI
	{
		public Var(VarI1 val) : base(val)
		{
		}

		public Set1 vars => new Set1( this.boxed);

		public op_.UnaryI op =>op_.unary_.Not.Singleton;

		public ExprI2 substitute(VarI1 var, ExprI2 expr)
		{
			throw new NotImplementedException();
		}
	}
}
