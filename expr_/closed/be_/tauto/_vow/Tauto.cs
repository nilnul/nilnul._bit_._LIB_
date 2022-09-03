using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
namespace nilnul.bit.expr
{
	public class Tauto
	{



		static public void Assert( E x ) {

			nilnul.Assert1.True(
				nilnul.bit.expr.be.Tauto.Eval(x)
			);

		}
	}
}
