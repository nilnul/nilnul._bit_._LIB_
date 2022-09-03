using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._ident
{
	public abstract class TernaryA
	{
		private ExprI_membered _expr;
		public ExprI_membered expr
		{
			get {
				return _expr;
			}
			private set
			{
				_expr = value;
			}
		}

		public TernaryA(V v,V v1,V v2)
		{
			_expr = createExpr(v,v1,v2);
		}

		public TernaryA():this(new V(),new V(),new V())
		{

		}

		public abstract ExprI_membered createExpr(V v,V v1,V v2);
		public void assert()
		{
			nilnul.bit.expr.Tauto.Assert(_expr);
		}
	}
}
