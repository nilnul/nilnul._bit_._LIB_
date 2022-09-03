using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.be_
{
	/// <summary>
	/// contradictionary; always false
	/// </summary>
	public class Contra:

		nilnul.bit.expr_.plain.BeI
	{

		
		 public bool be(nilnul.bit.expr_.PlainI expr)
		{
			///todo assign each value.
			/// 
			var vars = (expr ).vars;

			//bit.expr.stati.StatiI reduced;

			if (vars.Count == 0)
			{
				return !plain_.call_.form._ReduceX._Eval(expr);
					
			}

			var firstVar = vars.First();


			return be(
				expr.substitute(firstVar, bit.expr_.plain_.call_.Nary.CreateNil())
			)
			&&
			be(
				expr.substitute(firstVar, bit.expr_.plain_.call_.Nary.CreateOne())
			);

			//throw new NotImplementedException();
		}

		static public Contra Singleton
		{
			get
			{
				return nilnul.Singleton1<Contra>.Instance;
			}
		}
	}
}