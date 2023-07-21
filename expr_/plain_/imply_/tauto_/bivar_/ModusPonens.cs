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
	/// (x->y) & x =>  y
	/// </summary>
	public class ModusPonens :_deduce.BinaryA
	{

		public ModusPonens(V v, V v1):base(v,v1)
		{

		}

		public ModusPonens():base()
		{

		}


		public override IEnumerable< ExprI_membered> createPremises(Var2 v, Var2 v1) {

			yield return nilnul.bit.expr.duo.Call.CreateImply(v, v1);
			yield return new VarAsExpr(v);
		}

		

	

		public override ExprI_membered createConclusion(Var2 v, Var2 v1)
		{
			return new VarAsExpr(v1);
			throw new NotImplementedException();
		}
	}
}
