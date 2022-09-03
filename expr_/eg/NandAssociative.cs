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
	public class NandAssociative : nilnul.bit.expr.duo.Call
	{

		static public readonly NandAssociative Singleton = SingletonByDefault<NandAssociative>.Instance;

		public NandAssociative(V p, V q, V r)
			: base(
				 nilnul.bit.duo.op.Eq.Singleton,

				 nilnul.bit.expr.duo.Call.CreateNi(

					nilnul.bit.expr.duo.Call.CreateNi(p, q)
					,
					r
				)
				 ,
				 nilnul.bit.expr.duo.Call.CreateNi(
					 p,

					nilnul.bit.expr.duo.Call.CreateNi(q, r)
				)

			 )
		{
		}

		public NandAssociative() : this(new Var2(), new Var2(),new Var2())
		{
		}


	}
}
