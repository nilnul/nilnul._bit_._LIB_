using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._infer
{
	public abstract class TernaryA:InferA
	{
		

		public TernaryA(V v,V v1,V v2)
		{
			_expr = createExpr(v,v1,v2);
		}

		public TernaryA():this(new V(),new V(),new V())
		{

		}


		public ExprI_membered createExpr(V v, V v1,V v2) {
			return nilnul.bit.expr.duo.Call.CreateImply(
				createPrecedent(v, v1,v2)
				,
				createSubsequent(v, v1,v2)
			);
		}
		public abstract ExprI_membered createPrecedent(V v,V v1,V v2);

		public abstract ExprI_membered createSubsequent(V v,V v1, V v2);
		
	
	}


}
