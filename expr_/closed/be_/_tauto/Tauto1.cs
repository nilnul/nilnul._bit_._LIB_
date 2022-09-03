using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be
{
	/*extern alias obj;*/
	/// <summary>
	/// if it's var, not var, no.call.
	/// </summary>
	/// 
	[Obsolete(nameof(be_.Tauto))]
	public class Tauto1:

		/*obj::*/nilnul.obj.BeI1<nilnul.bit.ExprI1>
	{
		static public bool Eval(nilnul.bit.ExprI1 expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr as bit._expr_.VarsI).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count == 0)
			{
				return (
					(expr as bit._expr_.ReduceI).reduce() 
					as 
					
					bit.expr.call_.No
					// nilnul.expr.no._call EvalI<TR>

				).eval();
			}

			var firstVar = vars.First();


			return Eval(
				expr.substitute(firstVar, bit.expr.call_.No.CreateNil())
			)
			&&
			Eval(
				expr.substitute(firstVar, bit.expr.call_.No.CreateOne())
			);




			throw new NotImplementedException();
		}

		public bool be(ExprI1 obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}

		public class En :nilnul.obj.be.En_beDefaultable<ExprI1, Tauto1>
		{
			public En(ExprI1 expr):base(expr)
			{

			}

			public override string ToString()
			{
				return $"=>" + avowed.ToString();
			}
		}
	}


}
