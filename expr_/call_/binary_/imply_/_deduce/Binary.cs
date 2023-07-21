using System.Collections.Generic;
using nilnul.bit.expr.set.call;

using System.Linq;
using System;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr.infer._deduce
{
	public abstract class BinaryA:Deduce
	{

		public BinaryA(Var2 v,Var2 v1 )
			
		{
			this._evidence = createEvidence(v,v1);
			this._conclusion = createConclusion(v, v1);
		}

		public BinaryA():this(new V(),new V())
		{

		}

		public abstract IEnumerable<ExprI_membered> createPremises(Var2 v, Var2 v1);





		public nilnul.bit.expr.set.call.Conjunct createEvidence(Var2 v, Var2 v1)
		{
			return new Conjunct(createPremises(v, v1));
		}
		
		public abstract ExprI_membered createConclusion(Var2 v, Var2 v1)
		;


	}
}