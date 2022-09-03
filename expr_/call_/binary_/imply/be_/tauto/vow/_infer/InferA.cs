using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.Var2;

namespace nilnul.bit.expr._infer
{
	public abstract class InferA
	{
		protected ExprI_membered _expr;
		public ExprI_membered expr
		{
			get {
				return _expr;
			}
			protected set
			{
				_expr = value;
			}
		}

		
		public void assert()
		{
			nilnul.bit.expr.Tauto.Assert(_expr);
		}
	}
}
