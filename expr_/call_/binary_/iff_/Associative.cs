using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr_.call_.duo_.equiv_
{
	public class Associative
	{
		static public nilnul.bit.expr_.call_.Duo1 Create(nilnul.bit.CombineI op,  V x, V y, V z)
		{
			return  nilnul.bit.expr_.call_.Duo1.CreateEq(
				new nilnul.bit.expr_.call_.Duo1(
					op
					,
					new nilnul.bit.expr_.call_.Duo1(
						bit.combine_.Nand.Singleton
						,
						x,
						y
					)
					, 
					z
				)
				,
				new nilnul.bit.expr_.call_.Duo1(
					op
					,
					x
					,
					new nilnul.bit.expr_.call_.Duo1(
						op
						,
						y,
						z
					)
				)
			);
		}
	}
}
