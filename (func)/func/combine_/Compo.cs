using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.combine_
{
	static public class _CompoX 
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="inner">applied first to the argument</param>
		/// <param name="outer">applied second to the argument</param>
		/// <returns></returns>
		/// <remarks>
		///  supposing innerFunc = [x,x1,x2,x3,x4] => expr1
		///  outerFunc= [y,y1,y2,y3,y4] => expr2
		///  
		/// then outerFunc * innerFunc = [x_,x1_,x2_,x3_,x4_, y_,y1_,y2_,y3_ ] =>  outerFunc(y_,y1_,y2_,y3_, innerFunc(x_,x1_,x2_,x3_,x4_)  )
		/// 
		/// specifically 
		///		for innerFunc: f(x)=  x=> expr1, and outerFunc g(y)= y=>expr2
		/// then g(f(x)) = x=> g(expr1)
		///		and 
		///		for innerFunc f(x,x1) = x=> x1=>expr1 and outerFunc g(y) = y=>expr2
		///		then g(f(x,x1)) = x=>x1=>g(expr1)
		///		
		///		and for innerFunc f(x)= x=>expr1, and outerFunc g(y1,y)= y1=>y=>expr2
		///			then g(f(x),y ) = y=> g(f(x),y)  =  y=>x=>g(f(x),y)  = (y,x) => g(f(x),y)
		///			
		/// 
		/// </remarks>
		static public FuncI2 Op( FuncI2 outer, FuncI2 inner)
		{
			
			var innerParsNew = nilnul.bit.var.str_.seq_.distinct.constuct_._OfCountX.Construct(inner.pars.en.Count());


			//note the bound pars of outer may conflict the free pars of inner.

			///suppose we repar with news for all bound pars of both func
			///then we repar the pars with old ones if possible(old ones is not free or bound)


			return nilnul.bit.func.convert_.abstra.of_.sortie_._NonboundX._Op(
				nilnul.bit.func.convert_._ApplyX.Op(
					outer
					,
					nilnul.bit.func.convert_.apply._RepeatX.Op(
						inner,
						innerParsNew.Select(p => new nilnul.bit.expr_.plain_.Var(p))
					).expr
				)
				, 
				innerParsNew
			);
			
		}
	}
}
