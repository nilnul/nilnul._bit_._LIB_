using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.in2n.eg
{

	/// <summary>
	/// a collection of vars that is empty, with a complete group of ops, say, (not ,and ,or)
	/// </summary>
	public class TwoVars:In2nI
	{
		private V _v;

		public V v
		{
			get { return _v; }
			set { _v = value; }
		}

		private V _v1;

		public V v1
		{
			get { return _v1; }
			set { _v1 = value; }
		}

		/// <summary>
		/// a collection of all finite exprs.
		/// </summary>
		/// <returns></returns>

		public IEnumerable<ExprI_membered> CreateEnumerable() {

			yield return new nilnul.bit.expr.VarAsExpr(_v);
			yield return new nilnul.bit.expr.VarAsExpr(_v1);

			yield return  nilnul.bit.expr.no.Call.CreateNil();
			yield return  nilnul.bit.expr.no.Call.CreateOne();

			yield return nilnul.bit.expr.Call.CreateNeg(_v);
			yield return nilnul.bit.expr.Call.CreateNeg(_v1);

			/// 1&1， 1or 1, ...
			yield break;



		}
	}
}
