using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.eg
{
	public class P_le_Q__xor__P_le_notQ:nilnul.bit.expr.duo.Call
	{

		static public readonly P_le_Q__xor__P_le_notQ Singleton = SingletonByDefault<P_le_Q__xor__P_le_notQ>.Instance;

		public P_le_Q__xor__P_le_notQ(V p, V q)
			:base(
				nilnul.bit.duo.op.Ne.Singleton
				 ,
				nilnul.bit.expr.duo.Call.CreateImply(p, q)
				,
				nilnul.bit.expr.duo.Call.CreateImply(
					p
					,
					nilnul.bit.expr.Call.CreateNeg(q)
				)
			 )
		{
		}

		public P_le_Q__xor__P_le_notQ():this(new Var2(),new Var2())
		{
		}


	}
}
