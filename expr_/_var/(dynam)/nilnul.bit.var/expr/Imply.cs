using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.var.expr
{
	public partial class Imply
		:ExprI
	{

		static public ExprI Call(ExprI a,ExprI b) {

			return new Imply(a, b);
		
		}
		private ExprI _precedent;

		public ExprI precedent
		{
			get { return _precedent; }
			set { _precedent = value; }
		}

		private ExprI _consequent;

		public ExprI consequent
		{
			get { return _consequent; }
			set { _consequent = value; }
		}

		public Imply(ExprI precedent,ExprI consequent)
		{
			this.precedent = precedent;
			this.consequent = consequent;

		}
		
		
	}
}
