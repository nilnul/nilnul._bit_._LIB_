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
	/// 1 => !(x&!x)
	/// </summary>
	public class NoContra :_deduce.UnaryA
	{

		public NoContra(V v):base(v)
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v) {

			yield break;
		}

		

	

		public override ExprI_membered createConclusion(Var2 v)
		{
			return nilnul.bit.expr.Call.CreateNeg(
				
				nilnul.bit.expr.duo.Call.CreateMi(
					v
					,
					nilnul.bit.expr.Call.CreateNeg(v)
				)
			);
			throw new NotImplementedException();
		}
	}
}
