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

namespace nilnul.bit.expr.stati.duo
{

		public class Call: nilnul.obj.expr.stati.duo.Call<bit.duo.OpI,bool,bool,bool,bit.expr.stati.StatiI,bit.expr.stati.StatiI>
			,StatiI
		{

			public Call(
				bit.duo.OpI op,
					bit.expr.stati.StatiI x, bit.expr.stati.StatiI y
			)
				:base(op, x,y)
			{

			}

			public Call(
				bit.duo.OpI op,
					bit.expr.stati.StatiI x, bit.var.stati.Stati y
			)
				:
			this(op,
					x,new VarAsExpr(y)	 
				)
			
			{

			}



			public Call(
				bit.duo.OpI op,

				bit.var.stati.Stati x, bit.var.stati.Stati y

				)
				:this(op,
					new VarAsExpr(x),new VarAsExpr(y)	 
				)
			{

			}

		VSet _stati.VarsI.vars
		{
			get
			{

				var r = new VSet();
				r.UnionWith(
						(arg as bit.expr.stati._stati.VarsI).vars
			
					);
				r.UnionWith(
						(arg1 as bit.expr.stati._stati.VarsI).vars
			
					);
				return r;

				throw new NotImplementedException();
			}
		}

		public StatiI substitute(Stati var, StatiI expr)
		{
			return new Call(
				this.op ,
				(arg as bit.expr.stati._stati.SubstituteI).substitute(var, expr),
				(arg1 as bit.expr.stati._stati.SubstituteI).substitute(var, expr)

		);
			throw new NotImplementedException();
		}

		StatiI ReduceI<StatiI>.reduce()
		{
			var argReduced = (arg as ReduceI).reduce();
			var arg1Reduced = (arg1 as ReduceI).reduce();

			if (argReduced is no.Call && arg1Reduced is no.Call)
			{
				return new no.Call(
					op.eval(

						(argReduced as no.Call).eval()
						,
						(arg1Reduced as no.Call).eval()
					)

				);
			}
			else
			{
				return new Call(
					op
					,
					argReduced,arg1Reduced	
				);
			}

			throw new NotImplementedException();
		}
	}
	
}
