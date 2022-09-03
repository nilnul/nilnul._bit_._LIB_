using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using VSet = nilnul.bit.var.stati.Set;


namespace nilnul.bit.expr.stati.no
{

		public  class Call: nilnul.obj.expr.stati.no.Call< bool>
			,StatiI
		,ReduceI
		{



		public Call(
					bit.no.OpI op
			)
				:base(op)
			{

			}

		public Call(bool a)
			:this(
				 new bit.no.Constant(a) as bit.no.OpI
				)
		{

		}

		VSet _stati.VarsI.vars
		{
			get
			{
				
				return new bit.var.stati.Set();
				throw new NotImplementedException();
			}
		}

		public StatiI substitute(Stati var, StatiI expr)
		{
			return this;
			throw new NotImplementedException();
		}

		StatiI ReduceI<StatiI>.reduce()
		{
			return this;
			
			throw new NotImplementedException();
		}

		static public implicit operator Call(bool a) {
			return new Call(a);
		}
	}
	
}
