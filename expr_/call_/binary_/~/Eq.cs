using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.duo_
{
	[Obsolete()]
	public class Equiv : duo.be_.equiv.vow.Ed
		,ExprI1
	{
		

		public Equiv(Duo1 val) : base(val)
		{
		}

		public Equiv(ExprI1 a, ExprI1 b)
			:this(Duo1.CreateEq(a,b))
		{
			
		}

		public Set1 vars
		{
			get
			{
				return vowed.vars;
				throw new NotImplementedException();
			}
		}

		public ExprI1 reduce()
		{
			return vowed.reduce();
			throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI1 var, ExprI1 expr)
		{
			return vowed.substitute(var,expr);
			throw new NotImplementedException();
		}
	}
}
