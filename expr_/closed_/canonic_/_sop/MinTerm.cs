using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.stati._cannonic
{
	/// <see cref="expr_.var.set.allot"/>, <see cref="expr_.var.sortie.allots_.omni.Poll"/>
	/// <see cref="bit.var.set.ballot"/>
	/// <see cref="bit.var.sortie"/>
	/// <see cref="bit.var.sort.Minterm"/>
	/// <summary>
	/// generate the minterms for given vars;
	/// </summary>
	public class MinTerm
	{
		private nilnul.bit.var.stati.str.be.Distinct.Asserted _vars;

		public nilnul.bit.var.stati.str.be.Distinct.Asserted vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> eval() {


			return _Eval(_vars.val);



		}
		static public IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> _Eval(
			IEnumerable<bit.var.stati.Stati> _vars_distinctStr
			
		) {

			if (_vars_distinctStr.Count()==0)
			{
				yield break;

			}

			foreach (var item in _Eval_varDistinctFromCall(_vars_distinctStr.First(),_vars_distinctStr.Skip(1)))
			{
				yield return item;


			}




		}

		static private IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> _Eval_varDistinctFromCall( bit.var.stati.Stati var, IEnumerable<Stati> call) {

			foreach (var item in _Eval(call))
			{
				foreach (var item1 in _Eval_varDistinctFromCall(var, item))
				{
					yield return item1;
				}
			}

		}



		static private IEnumerable<bit.expr.stati.simple.str.op.Conjunct.Call> _Eval_varDistinctFromCall( bit.var.stati.Stati var, bit.expr.stati.simple.str.op.Conjunct.Call call) {

			yield return new bit.expr.stati.simple.str.op.Conjunct.Call(
				nilnul.seq.Head.Eval<bit.expr.stati.be.Simple.Asserted>(  new bit.expr.stati.be.Simple.Asserted( var), call.arg)	
			);
			yield return new bit.expr.stati.simple.str.op.Conjunct.Call(
				nilnul.seq.Head.Eval<bit.expr.stati.be.Simple.Asserted>(  new bit.expr.stati.be.Simple.Asserted( bit.expr.stati.mono.CallX.CreateNeg( var)), call.arg)	
			);

		}


	}
}
