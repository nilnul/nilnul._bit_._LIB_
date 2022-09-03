using nilnul.bit.expr.var;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed.be_
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
	public class Tauto_generi:

		/*obj::*/nilnul.obj.BeI1<nilnul.bit.expr_.Closed>
	{
		

		public bool be(expr_.Closed  expr)
		{
			///todo assign each value.
			///
			/// 
			///
			
			var vars =nilnul.obj.expr_.typed_.generi_.closed._VarsX.Vars(expr);

			//bit.expr.stati.StatiI reduced;
			
			if (vars.Count == 0)
			{
				return 
					nilnul.bit.expr_.calc._EvalX1.Eval_assumeCalc
					(expr.ee.expr.ee ) 
					;
			}

			var firstVar = vars.First();


			return be(
				bit.expr.var.SubstituteX.Substitute(
					expr,firstVar, bit.expr_.call_.nary_.Nil_generi.Singleton
				)
			)
			&&
			be(
				bit.expr.var.SubstituteX.Substitute(
					expr
					,
					firstVar
					,
					bit.expr_.call_.nary_.One2.Singleton
				)
			);




			//throw new NotImplementedException();
		}
		


		public bool be(Expression ex) {
			return be(new Expr_generi(ex));
		}


		public bool be(ExprI_generi expr_generi)
		{
			return be(
				new expr_.Closed(expr_generi)
			);
			//throw new NotImplementedException();
		}
		public bool be(bit.expr_.call_.Binary_generi expr_generi)
		{
			return be(
				new expr_.Closed(expr_generi)
			);
			//throw new NotImplementedException();
		}


		static public Tauto_generi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tauto_generi>.Instance;
			}
		}

	}


}
