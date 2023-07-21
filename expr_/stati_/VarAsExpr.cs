using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.obj.expr.stati._stati;
using VSet = nilnul.bit.var.stati.Set;


namespace nilnul.bit.expr.stati
{
	[Obsolete()]
	public class VarAsExpr:nilnul.obj.expr.stati.VarAsStati<bool>,StatiI
		,_stati.ReduceI
	{
		public VarAsExpr(bit.var.stati.Stati x)
			:base(x)
		{

		}

		VSet _stati.VarsI.vars
		{
			get
			{
				return new bit.var.stati.Set() { this.var as bit.var.stati.Stati };
				throw new NotImplementedException();
			}
		}

		static public implicit operator VarAsExpr(bit.var.stati.Stati x) {

			return new VarAsExpr(x);

		}

		public StatiI substitute(Stati var, StatiI expr)
		{
			if (this.var == var)
			{
				return expr;
			}
			else
			{
				return this;
			}

			throw new NotImplementedException();
		}

		StatiI ReduceI<StatiI>.reduce()
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
