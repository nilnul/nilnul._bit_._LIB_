using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be
{
	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	/// 
	[Obsolete(nameof(expr.be_.Tauto))]
	public class Tauto:nilnul.BeI<nilnul.bit.ExprI_membered>
	{
		static public bool Eval(nilnul.bit.ExprI_membered expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr as bit._expr.VarsI).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count == 0)
			{
				return (
					(expr as bit._expr.ReduceI).reduce() 
					as 
					
					bit.expr.no.Call
					// nilnul.expr.no._call EvalI<TR>

				).eval();
			}

			var firstVar = vars.First();


			return Eval(
				expr.substitute(firstVar, bit.expr.no._zero.Call.Singleton)
			)
			&&
			Eval(
				expr.substitute(firstVar, bit.expr.no._one.Call.Singleton)
			);




			throw new NotImplementedException();
		}

		public bool be(ExprI_membered obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class En :nilnul.be.Asserted<ExprI_membered, Tauto>
		{
			public En(ExprI_membered expr):base(expr)
			{

			}

			public override string ToString()
			{
				return $"=>" + val.ToString();
			}
		}
	}


}
