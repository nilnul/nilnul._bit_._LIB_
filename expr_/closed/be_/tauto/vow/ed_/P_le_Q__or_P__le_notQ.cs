using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.tauto.eg
{
	public class P_le_Q__or__P_le_notQ:nilnul.bit.expr.be.Tauto.En
	{

		static public readonly P_le_Q__or__P_le_notQ Singleton = SingletonByDefault<P_le_Q__or__P_le_notQ>.Instance;


		public P_le_Q__or__P_le_notQ(V x, V y):base(nilnul.bit.expr.eg.P_le_Q__or__P_le_notQ.Create(x,y))
		{

		}

		public P_le_Q__or__P_le_notQ():this(new Var2(),new Var2())
		{

		}
	}
}
