using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.infer_
{
	/// <summary>
	/// x & (x->y) ->y
	/// </summary>
	public class ModusPonens : Infer
	{
		public ModusPonens(V x, V y) : base(

			bit.expr_.call_.Duo1.CreateMi(
				x
				,
				bit.expr_.call_.Duo1.CreateImply(
					x
					,
					y
				)
			)
			,
			y
		)
		{

		}

		public ModusPonens():this(new V(),new V())
		{

		}


		static public readonly ModusPonens Singleton = nilnul.obj.SingletonByDefault<ModusPonens>.Instance;




	}
}
