using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.bit.expr.stati;

namespace nilnul.bit.expr.duo._max
{

		public class Call: 

		bit.expr.duo.Call
		
//		nilnul.obj.expr.stati.duo.Call< bool>
			,ExprI_membered
		{

			public Call(
					bit.ExprI_membered x, bit.ExprI_membered y
			)
				:base(bit.duo.op.Ma.Singleton, x,y)
			{

			}

			public Call(
					bit.ExprI_membered x,
					
					bit.VarI1 y
			)
				:this(
					x,new VarAsExpr(y)	 
				)
			{

			}

			public Call(
					bool x,
					
					bit.VarI1 y
			)
				:this(
					new no.Call(x),
					
					new VarAsExpr(y)	 
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

		//Set VarsI.vars
		//{
		//	get
		//	{

		//		var r = new Set();
		//		r.UnionWith(
		//				(arg as bit.expr.stati._stati.VarsI).vars
			
		//			);
		//		r.UnionWith(
		//				(arg1 as bit.expr.stati._stati.VarsI).vars
			
		//			);
		//		return r;

		//		throw new NotImplementedException();
		//	}
		//}
	}
	
}
