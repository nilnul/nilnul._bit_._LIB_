using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr.vow_
{
	public class Tauto:nilnul.bit.expr.be_.tauto.Vow
	{


		static public readonly Tauto Singleton = nilnul.obj.SingletonByDefault<Tauto>.Instance;


		static public void Vow( E x ) {

			nilnul.obj.vow_.True.Vow(
				nilnul.bit.expr.be_.Tauto.Eval(x)
			);

		}
	}
}
