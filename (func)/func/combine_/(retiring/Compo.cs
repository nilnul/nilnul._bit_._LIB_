using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.combine_
{
	public class Compo : CombineI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="innerFunc">applied first to the argument</param>
		/// <param name="outer">applied second to the argument</param>
		/// <returns></returns>
		/// <remarks>
		///  supposing innerFunc = [x,x1,x2,x3,x4] => expr1
		///  outerFunc= [y,y1,y2,y3,y4] => expr2
		///  
		/// then outerFunc * innerFunc = [y_,y1_,y2_,y3_, x_,x1_,x2_,x3_,x4_] =>  outerFunc(y_,y1_,y2_,y3_, innerFunc(x_,x1_,x2_,x3_,x4_)  )
		/// </remarks>
		public FuncI1 eval( FuncI1 outer, FuncI1 innerFunc)
		{
			if (!outer.vars.Any())
			{
				return new Func1(
					innerFunc.vars
					,
					outer.expr
				);
			}

			var outerVarsCountDecrease = outer.vars.Count() - 1;

			nilnul.bit.var.sortie_.List newVars = nilnul.bit.var.sortie_.List.CreateOfCount(outer.vars.Count()-1+ innerFunc.vars.Count());	 ///this is necessary for the vars in innerFunc might collide with vars in outerFunc


			return new Func1(
				newVars
				,
				nilnul.bit.func.convert_.Apply.Eval(
					outer,
				
					newVars.vars.Take(outerVarsCountDecrease).Select( v=>new nilnul.bit.expr_.VarAsExpr(v) ).Concat(
						new[] {
							nilnul.bit.func.convert_.Apply.Eval(
								innerFunc,
								newVars.vars.Skip(outerVarsCountDecrease).Select( v=>new nilnul.bit.expr_.VarAsExpr(v) ).ToArray()
							).expr
						}
					).ToArray()
				).expr
			);

			throw new NotImplementedException();
		}
	}
}
