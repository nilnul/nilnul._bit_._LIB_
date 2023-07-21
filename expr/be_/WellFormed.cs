using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati.be
{
	/// <summary>
	/// not and or imply equiv
	/// </summary>
	/// 
	[Obsolete("Logic")]
	public class WellFormed
	{
		static public bool Eval(
			StatiI stati
		) {
			if (stati is VarAsExpr)
			{
				return true;
			}
			if (stati is no.Call)
			{
				return true;

			}
			if (stati is mono.Call)
			{

				return Eval(stati as mono.Call);
			}
			if (stati is duo.Call)
			{
				return Eval(stati as duo.Call);

			}
			return false;
			throw new NotImplementedException("");

		}

		static public bool Eval(
			mono.Call monoCall
		) {

			if (monoCall.op is bit.mono.op.Not)
			{
				return Eval(monoCall.arg);
			}
			return false;
		}

		static public bool Eval(
			duo.Call call
		) {

			if (
				
				call.op is bit.duo.op.Ma || call.op is bit.duo.op.Mi || call.op is bit.duo.op.Le|| call.op is bit.duo.op.Eq
				
				)
			{
				return Eval(call.arg) && Eval(call.arg1);
			}
			return false;
		}


	}
}
