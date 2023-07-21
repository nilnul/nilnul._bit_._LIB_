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
	public class One_le_Q__xor__One_le_notQ:nilnul.bit.expr.duo.Call
	{
		static public readonly One_le_Q__xor__One_le_notQ Singleton = SingletonByDefault<One_le_Q__xor__One_le_notQ>.Instance;

		public One_le_Q__xor__One_le_notQ( V q)
			:base(
				nilnul.bit.duo.op.Ne.Singleton
				 ,
				nilnul.bit.expr.duo.Call.CreateImply(1, q)
				,
				nilnul.bit.expr.duo.Call.CreateImply(
					1
					,
					nilnul.bit.expr.Call.CreateNeg(q)
				)
			 )
		{

		}

		public One_le_Q__xor__One_le_notQ():this(new Var2())
		{
		}


	}
}
