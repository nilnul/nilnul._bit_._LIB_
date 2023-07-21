using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr
{
	public partial class Negate
		:ExprI
	{
		static public Negate Do(
			ExprI a	
		) {
			return new Negate(a);
		}

		private ExprI _expr;

		public ExprI expr
		{
			get { return _expr; }
			set { _expr = value; }
		}
		public Negate(ExprI a)
		{
			this.expr = a;

		}
		
	}
}
