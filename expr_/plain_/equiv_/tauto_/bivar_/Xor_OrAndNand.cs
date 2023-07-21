using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_.iff_.tauto_
{
	/// <summary>
	/// x^y = (x|y) & (x nand y)
	/// </summary>
	public class Xor_OrAndNand
		: bit.expr_.call_.binary_.iff_.Tauto
	{
		

		public Xor_OrAndNand(expr_.Var_sys x, expr_.Var_sys y) : base(

			new binary_.Xor(x,y)
			,
			new binary_.And(
				new binary_.Or(
					x,y
				)
				,
				new binary_.Nand(x,y)
			)

		)
		{
		}
		public Xor_OrAndNand(string x, string y):this(new Var_sys(x), new Var_sys(y))
		{

		}
	}
}
