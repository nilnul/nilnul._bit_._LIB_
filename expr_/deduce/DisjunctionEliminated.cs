using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.set.call;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr.infer.deduce
{
	/// <summary>
	/// 
	/// </summary>
	public class DisjunctionEliminated :_deduce.TernaryA
	{

		public DisjunctionEliminated(V v, V v1, V v2):base(v,v1,v2)
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v, Var2 v1, Var2 v2) {

			yield return nilnul.bit.expr.duo.Call.CreateMa(v, v1);
			yield return nilnul.bit.expr.duo.Call.CreateImply(v, v2);
			yield return nilnul.bit.expr.duo.Call.CreateImply(v1, v2);
		}

		

	

		public override ExprI_membered createConclusion(Var2 v, Var2 v1, Var2 v2)
		{
			return new VarAsExpr(v2);
			throw new NotImplementedException();
		}
	}
}
