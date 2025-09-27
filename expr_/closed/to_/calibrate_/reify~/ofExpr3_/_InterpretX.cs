using nilnul.bit.expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(expr_.closed._ReifyX))]
	static public class _InterpretX
	{
		static public nilnul.bit.expr._interpret.Tabuleau GetTruthTable(this bit.ExprI3 expr)
		{


			var vars = (expr).vars;

			var vals_enumerated = nilnul.bit.var.set.BallotsX._EnumerateToBallots(vars).ToList();

#if DEBUG



			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars.OrderBy( x=>x, nilnul.obj.var.comparer_.FroNaming.Lazy)).ToList();

#else
			//var assignments = nilnul.bit.var.set.Assignment._Enumerate(vars);


#endif


			var results = vals_enumerated.Select(x => new nilnul.bit.expr._interpret.Row(x, _InterpretX.Eval(expr, x)));

			var truthTable = new nilnul.bit.expr._interpret.Tabuleau(
				vars,
				results
			);
			return truthTable;


		}

		/// <summary>
		/// <seealso cref="bit.expr_.capsule.to_.ICalculate"/>
		/// </summary>
		/// <param name="expr"></param>
		/// <param name="assignment_allVars"></param>
		/// <returns></returns>

		static public bool Eval(nilnul.bit.ExprI3 expr,  bit.var.set.Ballot assignment_allVars)
		{
			nilnul.obj.aver_.True.Aver(
				nilnul.bit.var.set.EqOfEnumerable.Instance.Equals((expr ).vars, assignment_allVars.Keys)	
			);
			
			var result=expr;

			foreach (var item in (expr).vars)
			{
				result = result.substitute(item, (nilnul.bit.expr_.call_.Nary) assignment_allVars[item] );
			}
		
			return nilnul.bit.expr_.plain_.calc._CalcX._Reduce_assumePlainCalc ((result));
			//throw new NotImplementedException();
		}

		static public bool Eval(nilnul.bit.ExprI3 expr,  bit.var.set.State assignment_allVars)
		{
			nilnul.obj.aver_.True.Aver(
				nilnul.bit.var.set.EqOfEnumerable.Instance.Equals((expr ).vars, assignment_allVars.Keys)	
			);
			
			var result=expr;

			foreach (var item in (expr).vars)
			{
				result = result.substitute(item, (nilnul.bit.expr_.call_.Nary) assignment_allVars[item] );
			}
		
			return nilnul.bit.expr_.plain_.calc._CalcX._Reduce_assumePlainCalc ((result));
			//throw new NotImplementedException();
		}


		static public bool Eval(nilnul.bit.ExprI1 expr,  bit.var.set.State assignment_allVars)
		{
			nilnul.obj.aver_.True.Aver(
				nilnul.bit.var.set.EqOfEnumerable.Instance.Equals((expr ).vars, assignment_allVars.Keys)	
			);
			
			var result=expr;

			foreach (var item in (expr).vars)
			{
				result = result.substitute(item, (nilnul.bit.expr.call_.No) assignment_allVars[item] );
			}
		
			return ((result).reduce() as bit.expr.call_.NoI).eval();
			//throw new NotImplementedException();
		}

	}
}
