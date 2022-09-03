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
	public class Biconditional :_deduce.BinaryA
	{

		public Biconditional(V v, V v1):base(v,v1)
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v, Var2 v1) {

			yield return nilnul.bit.expr.duo.Call.CreateImply(v, v1);
			yield return nilnul.bit.expr.duo.Call.CreateImply(v1, v);
		}

		

	

		public override ExprI_membered createConclusion(Var2 v, Var2 v1)
		{
			return nilnul.bit.expr.duo.Call.CreateEq(v, v1);
			throw new NotImplementedException();
		}
	}
}
