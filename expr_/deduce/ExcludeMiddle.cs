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
	public class ExcludeMiddle :_deduce.UnaryA
	{

		public ExcludeMiddle(V v):base(v)
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v) {

			yield break;
		}

		

	

		public override ExprI_membered createConclusion(Var2 v)
		{
			return nilnul.bit.expr.duo.Call.CreateMa(v
				,
				nilnul.bit.expr.Call.CreateNeg(v)
			);
			throw new NotImplementedException();
		}
	}
}
