using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.duo._eq
{

		public class Call
		:
		bit.expr.stati.duo.Call
		
	//	nilnul.obj.expr.stati.duo.Call< bool>
			,StatiI
		{

			public Call(
					bit.expr.stati.StatiI x, bit.expr.stati.StatiI y
			)
				:base(bit.duo.op.Eq.Singleton, x,y)
			{

			}
			public Call(
					bit.expr.stati.StatiI x
				,
					bit.var.stati.Stati y
			)
				:this( x
					 
					 ,
					 new VarAsExpr(y)
					 
					 
					 )
			{

			}


			public Call(
					bit.expr.stati.StatiI x
				,
					bool y
			)
				:this( x
					 
					 ,
					 new no.Call(y)
					 
					 
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

		}
	
}
