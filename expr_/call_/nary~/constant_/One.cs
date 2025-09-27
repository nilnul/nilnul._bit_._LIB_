using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.var;

namespace nilnul.bit.expr.constant_
{
	public class One : nilnul.bit.expr.ConstantI
	{
		public nilnul.bit.var.Set1 vars
		{
			get
			{
				return nilnul.bit.var.Set1.CreateEmpty();
				//throw new NotImplementedException();
			}
		}

		public ExprI1 reduce()
		{
			return this;
			//throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI1 var, ExprI1 expr)
		{
			return this;
			//throw new NotImplementedException();
		}
	}
}
