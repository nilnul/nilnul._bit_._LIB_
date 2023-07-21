using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo_.equiv.be_.tauto
{
	public class Vow
		:     nilnul.obj.be.Vow_beDefault<nilnul.bit.expr_.call_.duo_.Equiv, nilnul.bit.expr_.call_.duo.be_.equiv.vow.ed.be_.Tauto>

	{

		static public Vow Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Vow>.Unison;
			}
		}


		[Obsolete(nameof(Unison))]
		static public readonly Vow Singleton = nilnul.obj.SingletonByDefault<Vow>.Instance;

		public void vow(Duo1 duoExpr)
		{

			base.vow(
				new nilnul.bit.expr_.call_.duo_.Equiv(duoExpr)
			);
		//	throw new NotImplementedException();
		}
	}
}
