using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr
{
	public partial class Var:
		ExprI
	{
		private VarI _var;

		public VarI var
		{
			get { return _var; }
			set { _var = value; }
		}

		
	}
}
