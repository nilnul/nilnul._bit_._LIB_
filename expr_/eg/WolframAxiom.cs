using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.eg
{
	public class WolframAxiom :
		bit.expr.duo.Call
		, ExprI_membered
	{

		static public readonly WolframAxiom Singleton = SingletonByDefault<WolframAxiom>.Instance;

		public WolframAxiom(
					V p, V q, V r
		): base(

			bit.duo.op.Eq.Singleton,

			bit.expr.duo.op.Nand.Eval(
				duo.op.Nand.Eval(
					duo.op.Nand.Eval(p, q)
					,
					r
				 )
				,
				duo.op.Nand.Eval(
					p
					,
					 duo.op.Nand.Eval(
						duo.op.Nand.Eval(p, r)
						,
						p
					)
				)
			)
			,
			r
		)
		{

		}

		public WolframAxiom() : this(
			new Var2()
			,new Var2()
			,new Var2()
		)
		{

		}


	}

}
