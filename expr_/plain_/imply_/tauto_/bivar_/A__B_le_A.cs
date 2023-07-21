using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr_.infer_
{
	/// <summary>
	/// x => y->x
	/// </summary>
	public class A__B_le_A:Infer
	{

		public A__B_le_A(V x, V y):base( 
			x, 
			nilnul.bit.expr_.call_.Duo1.CreateImply(y,x)
			
		)
		{

		}

		public A__B_le_A():this(new V(),new V())
		{

		}


		static public readonly A__B_le_A Singleton = nilnul.obj.SingletonByDefault<A__B_le_A>.Instance;





	}
}
