using nilnul.bit.expr.var;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
	[Obsolete(nameof(nilnul.bit.expr_.closed.be_.Tauto_generi) )]
	public class Tauto_sys:

		/*obj::*/nilnul.obj.BeI1<nilnul.bit.Expr_sys>
	{
		public bool be(expr_.call_.binary_.Iff_sys expr) {
			return be(
				(ExprI_sys)expr
			);
		}

		public bool be(ExprI_sys  expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr ).Vars();

			//bit.expr.stati.StatiI reduced;
			
			if (vars.Count == 0)
			{
				return 
					nilnul.bit.expr_.calc._EvalX1.Eval_assumeCalc
					(expr ) 
					;
			}

			var firstVar = vars.First();


			return be(
				bit.expr.var.SubstituteX.Substitute(
					expr,firstVar, bit.expr_.call_.nary_.Nil_sys.Singleton
				)
			)
			&&
			be(
				bit.expr.var.SubstituteX.Substitute(
					expr
					,
					firstVar
					,
					bit.expr_.call_.nary_.One1.Singleton
				)
			);




			//throw new NotImplementedException();
		}
		

		public bool be(Expr_sys  expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr ).vars;

			//bit.expr.stati.StatiI reduced;
			
			if (vars.Count == 0)
			{
				return 
					nilnul.bit.expr_.calc._EvalX1.Eval_assumeCalc
					(expr ) 
					;
			}

			var firstVar = vars.First();


			return be(
				bit.expr.var.SubstituteX.Substitute(
					expr,firstVar, bit.expr_.call_.nary_.Nil_sys.Singleton.sys.ee.lambda
				)
			)
			&&
			be(
				bit.expr.var.SubstituteX.Substitute(
					expr
					,
					firstVar
					,
					bit.expr_.call_.nary_.One1.Singleton.sys.ee.lambda
				)
			);




			//throw new NotImplementedException();
		}

		public bool be(Expression ex) {
			return be(new Expr_sys(ex));
		}
		static public Tauto_sys Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tauto_sys>.Instance;
			}
		}

	}


}
