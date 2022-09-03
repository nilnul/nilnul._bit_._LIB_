using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_.unary_;
using nilnul.bit.var;
using E = nilnul.bit.ExprI3;

namespace nilnul.bit.expr_.call_.binary_
{

	public class Imply :nilnul.bit.expr_.call_.Binary1
		//,ExprI1
	{

		public Imply(nilnul.bit.expr.Co val) : base(nilnul.bit.op_.binary_.Imply.Singleton,  val)
		{
		}

		public Imply(E x, E y):base(nilnul.bit.op_.binary_.Imply.Singleton,x,y )
		{

		}

		public Imply(VarI1 a1, VarI1 a2):this( new expr_.Var1(a1), new expr_.Var1(a2)  )
		{
		}

		public Imply(VarI1 a1, Not not):this(
			new nilnul.bit.expr_.Var1(a1), not
		)
		{
		}

		//public Set1 vars
		//{
		//	get
		//	{
		//		return vowed.vars;
		//		throw new NotImplementedException();
		//	}
		//}

		//public ExprI3 reduce()
		//{
		//	return vowed.reduce();
		//	throw new NotImplementedException();
		//}

		//public ExprI1 substitute(VarI1 var, ExprI1 expr)
		//{
		//	return vowed.substitute(var,expr);
		//	throw new NotImplementedException();
		//}
	}
}
