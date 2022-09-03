using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo_.imply.be_.tauto
{
	public class Vow
		:nilnul.obj.be.Vow_beDefault<nilnul.bit.expr_.call_.duo_.Imply, nilnul.bit.expr_.call_.duo_.imply.be_.Tauto>
	{
		static public void Eval(bit.ExprI1 A, bit.ExprI1 B) {

			nilnul.obj.vow_.True.Vow(
				nilnul.bit.expr_.call_.duo_.imply.be_.Tauto.Eval(A,B)
			);

		}
	}
}
