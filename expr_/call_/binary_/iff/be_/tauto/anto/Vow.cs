using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.call_.binary_.eq.be_.tauto.anto
{
	public class Vow
		:     nilnul.obj.be.Vow_beDefault<nilnul.bit.expr_.call_.duo_.Equiv, nilnul.bit.expr_.call_.binary_.eq.be_.tauto.Anto>

	{

		static public readonly Vow Singleton = nilnul.obj.SingletonByDefault<Vow>.Instance;

		public void vow(Duo1 duoExpr)
		{

			base.vow( new nilnul.bit.expr_.call_.duo_.Equiv(duoExpr) );
		//	throw new NotImplementedException();
		}

		public void vow(E x, E y){
			vow(Duo1.CreateEq(x,y));
		}
	}
}
