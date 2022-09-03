using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo_.eq.be_.tauto
{
	public class Vow
		:     nilnul.obj.be.Vow_beDefault<nilnul.bit.expr_.call_.duo_.Equiv, nilnul.bit.expr_.call_.duo_.eq.be_.Tauto>

	{

		static public readonly Vow Singleton = nilnul.obj.SingletonByDefault<Vow>.Instance;

		public void vow(Duo1 duoExpr)
		{

			vow( new nilnul.bit.expr_.call_.duo_.Equiv(duoExpr) );
		//	throw new NotImplementedException();
		}
	}
}
