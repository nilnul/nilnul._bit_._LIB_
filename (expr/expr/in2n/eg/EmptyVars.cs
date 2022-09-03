using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.in2n.eg
{

	/// <summary>
	/// a collection of vars that is empty, with a complete group of ops, say, (not ,and ,or)
	/// </summary>
	public class EmptyVars:In2nI
	{
		static public IEnumerable<ExprI_membered> CreateEnumerable() {

			yield return  nilnul.bit.expr.no.Call.CreateNil();
			yield return  nilnul.bit.expr.no.Call.CreateOne();

			/// 1&1， 1or 1, ...
			yield break;



		}
	}
}
