using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be_
{
	/*extern alias obj;*/
	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	/// <remarks>
	/// 恒真.
	///
	/// 不可判断 和 真  不可弄混。不可判断 和 假 不可弄混。
	/// </remarks>
	///

	[Obsolete(nameof( expr_.closed.be_.Tauto_generi	))]
	public class Tauto1:

		/*obj::*/nilnul.obj.BeI1<nilnul.bit.ExprI3>
	{
		static public bool Be(nilnul.bit.ExprI3 expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr ).vars;

			//bit.expr.stati.StatiI reduced;
			
			if (vars.Count == 0)
			{
				return 
					nilnul.bit.expr_.calc._EvalX.Eval
					(expr ) 
					;
			}

			var firstVar = vars.First();


			return Be(
				expr.substitute(firstVar, bit.expr_.call_.nary_.Nil.CreateNil())
			)
			&&
			Be(
				expr.substitute(firstVar, bit.expr_.call_.nary_.One.CreateOne())
			);




			//throw new NotImplementedException();
		}

		public bool be(ExprI3 obj)
		{
			return Be(obj);

		}

		
	}


}
