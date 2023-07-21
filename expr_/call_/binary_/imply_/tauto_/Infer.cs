using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_.duo_;
using E = nilnul.bit.ExprI1;
using V2 = nilnul.bit.Var2;

namespace nilnul.bit.expr_
{
	public class Infer : nilnul.bit.expr_.call_.binary_.le_.Tauto
	{
		//private E exprI1;

		public Infer(Imply val) : base(val)
		{
		}

		public Infer(V2 x, E y):this( new expr_.VarAsExpr(x), y)
		{
		}
		public Infer(E x, V2 y):this(x, new expr_.VarAsExpr( y))
		{
		}

		public Infer(E x, E y):this( new Imply(x,y))
		{

		}


	}
}
