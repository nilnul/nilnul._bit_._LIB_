using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;

namespace nilnul.bit
{


	[Obsolete()]
	public abstract class ExprA1 : ExprI2
	{
		

		public abstract Set1 vars { get; }

		public abstract ExprI2 substitute(VarI1 var, ExprI2 expr);
	}




}
