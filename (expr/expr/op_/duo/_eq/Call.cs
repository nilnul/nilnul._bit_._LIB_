using nilnul.bit.expr.stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.duo._eq
{

		public class Call
		:
		bit.expr.duo.Call
		
	//	nilnul.obj.expr.stati.duo.Call< bool>
			,ExprI_membered
		{

			public Call(
					bit.ExprI_membered x, bit.ExprI_membered y
			)
				:base(bit.duo.op.Eq.Singleton, x,y)
			{

			}
			public Call(
					bit.ExprI_membered x
				,
					bit.VarI1 y
			)
				:this( x
					 
					 ,
					 new VarAsExpr(y)
					 
					 
					 )
			{

			}

public Call(
					bit.VarI1 x1,

					bit.ExprI_membered y1
				 
			)
				:this(
						 new VarAsExpr(x1),y1
				 
					 
					 
					 )
			{

			}
			public Call(
					bit.ExprI_membered x
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
				bit.VarI1 x, bit.VarI1 y

				)
				:this(
					new VarAsExpr(x),new VarAsExpr(y)	 
				)
			{

			}

		}
	
}
