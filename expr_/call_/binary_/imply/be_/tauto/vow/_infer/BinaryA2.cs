using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._infer
{
	public abstract class BinaryA:InferA
	{
		

		public BinaryA(V v,V v1)
		{
			_expr = createExpr(v,v1);
		}

		public BinaryA():this(new V(),new V())
		{

		}


		public ExprI_membered createExpr(V v, V v1) {
			return nilnul.bit.expr.duo.Call.CreateImply(
				createPrecedent(v, v1)
				,
				createSubsequent(v, v1)
			);
		}
		public abstract ExprI_membered createPrecedent(V v,V v1);

		public abstract ExprI_membered createSubsequent(V v,V v1);
		
	
	}


}
