using System.Collections.Generic;
using nilnul.bit.expr.set.call;

using System.Linq;
using System;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr.infer._deduce
{
	public abstract class UnaryA:Deduce
	{

		public UnaryA(Var2 v )
			
		{
			this._evidence = createEvidence(v);
			this._conclusion = createConclusion(v);
		}


		public abstract IEnumerable<ExprI_membered> createPremises(Var2 v );





		public nilnul.bit.expr.set.call.Conjunct createEvidence(Var2 v)
		{
			return new Conjunct(createPremises(v));
		}
		
		public abstract ExprI_membered createConclusion(Var2 v)
		;


	}
}