using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr_.call_.duo_
{

	public class Imply : duo.be_.imply.vow.Ed
		,ExprI1
	{
		public Imply(Duo1 val) : base(val)
		{
		}

		public Imply(E x, E y):this( Duo1.CreateImply(x,y))
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
