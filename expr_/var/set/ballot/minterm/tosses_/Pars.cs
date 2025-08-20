using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_;

namespace nilnul.bit.var.set.minterm_.product
{
	static public class _Terms
	{

		static public IEnumerable<nilnul.bit.expr_.SimpleI> Exe(MintermI minterm) {

			return Exe(minterm.poll);
		}

		public static IEnumerable<SimpleI> Exe(Dictionary<VarI1, bool> dict)
		{
			foreach (var item in dict)
			{
				yield return item.Value? new nilnul.bit.expr_.VarAsExpr(item.Key) as SimpleI : new nilnul.bit.expr_.call_.unary_.neg_.Var(item.Key) ;
			}
			//throw new NotImplementedException();
		}
	}
	/// <summary>
	/// get the terms of the product
	/// </summary>
	 class Terms
	{

	}
}
