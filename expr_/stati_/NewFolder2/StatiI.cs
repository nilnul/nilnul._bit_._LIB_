using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.obj.expr;
using nilnul.obj.expr.stati._stati;
using nilnul.obj.var.stati;

namespace nilnul.bit.expr.stati
{
	public abstract class StatiA : StatiI
	{
		public abstract obj.var.stati.Set vars
		{
			get
			;
		}

		nilnul.bit.var.stati.Set _stati.VarsI.vars
		{
			get;
		}

		public abstract StatiI<bool> reduce()
		;

		public abstract StatiI substitute(Stati var, StatiI expr)
		;

		public abstract StatiI<bool> substitute<V>(obj.var.Stati<V> var, StatiI<V> expr)
		;

		StatiI ReduceI<StatiI>.reduce()
		{
			throw new NotImplementedException();
		}
	}

	class StatiX
	{
		
	}

	public  interface StatiI
		: obj.expr.StatiI<bool>
		,_stati.VarsI
		,_stati.SubstituteI
		,_stati.ReduceI
		, nilnul.bit.ExprI
	{

	}
}
