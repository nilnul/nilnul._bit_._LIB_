using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._ident
{
	public abstract class BinaryA
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

		public BinaryA(V v,V v1)
		{
			_expr = createExpr(v,v1);
		}


		public abstract ExprI_membered createExpr(V v,V v1);
		public void assert()
		{
			nilnul.bit.expr.Tauto.Assert(_expr);
		}
	}


}
