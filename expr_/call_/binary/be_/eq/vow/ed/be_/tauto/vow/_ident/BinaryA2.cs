using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._ident
{
	public abstract class BinaryA2
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

		public BinaryA2(V v,V v1)
		{
			_expr = createExpr(v,v1);
		}

		public BinaryA2():this(new V(),new V())
		{

		}


		public ExprI_membered createExpr(V v, V v1) {
			return nilnul.bit.expr.duo.Call.CreateEq(
				createPrecedent(v, v1)
				,
				createSubsequent(v, v1)
			);
		}
		public abstract ExprI_membered createPrecedent(V v,V v1);

		public abstract ExprI_membered createSubsequent(V v,V v1);
		
		public void assert()
		{
			nilnul.bit.expr.Tauto.Assert(_expr);
		}
	}


}
