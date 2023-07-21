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
	/// (x->y) &!y => x
	/// </summary>
	public class ModusTollens :_deduce.BinaryA
	{

		public ModusTollens(V v, V v1):base(v,v1)
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v, Var2 v1) {

			yield return nilnul.bit.expr.duo.Call.CreateImply(v, v1);
			yield return nilnul.bit.expr.Call.CreateNeg(v1);
		}

		

	

		public override ExprI_membered createConclusion(Var2 v, Var2 v1)
		{
			return nilnul.bit.expr.Call.CreateNeg(v);
			throw new NotImplementedException();
		}
	}
}
