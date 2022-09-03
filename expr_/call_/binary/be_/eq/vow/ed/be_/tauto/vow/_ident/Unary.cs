using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;
using V1 = nilnul.bit.VarI1;

namespace nilnul.bit.expr._ident
{
	public abstract class UnaryA1:Ident
	{
		

		public UnaryA1(V1 v)
			
		{
			_precedent = createPrecedent(v);
			_subsequent = createSubsequent(v);
			assert();
		}

		public UnaryA1():this(new V())
		{

		}

		public abstract ExprI_membered createPrecedent(V1 v);

		public abstract ExprI_membered createSubsequent(V1 v);

	}
}
