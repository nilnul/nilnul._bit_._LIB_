using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using VSet = nilnul.bit.var.stati.Set;


namespace nilnul.bit.expr.stati.duo._max
{

		public class Call: 

		bit.expr.stati.duo.Call
		
//		nilnul.obj.expr.stati.duo.Call< bool>
			,StatiI
		{

			public Call(
					bit.expr.stati.StatiI x, bit.expr.stati.StatiI y
			)
				:base(bit.duo.op.Ma.Singleton, x,y)
			{

			}

			public Call(
					bit.expr.stati.StatiI x,
					
					bit.var.stati.Stati y
			)
				:this(
					x,new VarAsExpr(y)	 
				)
			{

			}

			public Call(
					bool x,
					
					bit.var.stati.Stati y
			)
				:this(
					new no.Call(x),
					
					new VarAsExpr(y)	 
				)
			{

			}



			public Call(
				bit.var.stati.Stati x, bit.var.stati.Stati y

				)
				:this(
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
	}
	
}
