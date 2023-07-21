using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;
using nilnul.bit.expr_.call_.duo_;

namespace nilnul.bit.expr_.infer_
{
	/// <summary>
	/// a->b->c =>(a->b) ->a->c
	/// a->(b->c) =>(a->b) ->(a->c)
	/// 
	/// </summary>
	public class A_le_B_le_C___A_le_B__le__A_le_C : Infer
	{
		public A_le_B_le_C___A_le_B__le__A_le_C(V a, V b, V c) : base(
			nilnul.bit.expr_.call_.Duo1.CreateImply(
				a,
				nilnul.bit.expr_.call_.Duo1.CreateImply(b,c)
			)
			,
			nilnul.bit.expr_.call_.Duo1.CreateImply(

				nilnul.bit.expr_.call_.Duo1.CreateImply(a,b)
				,
				nilnul.bit.expr_.call_.Duo1.CreateImply(a,c)

			)

			
		)
		{
		}

		public A_le_B_le_C___A_le_B__le__A_le_C():this(new V(),new V(),new V())
		{

		}


		static public readonly A_le_B_le_C___A_le_B__le__A_le_C Singleton = nilnul.obj.SingletonByDefault<A_le_B_le_C___A_le_B__le__A_le_C>.Instance;



	}
}
