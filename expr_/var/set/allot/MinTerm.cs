using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// aka: subset of given vars
	/// </remarks>
	public class Minterm:var.Poll, MintermI
	{
		public Minterm(Dictionary<nilnul.bit.VarI1,bool> dict):base(dict)
		{

		}
		public Dictionary<VarI1, bool> dict => this;

		public Poll poll => this;

		static public bit.expr.simple.set.op.Conjunct.Call Eval(bit.var.set.Assignment assignment) {

			return  bit.expr.simple.set.op.Conjunct.Call.Create(
				assignment.Select(
					x=> 
					x.Value?
						( new bit.expr.VarAsExpr(x.Key)) as bit.ExprI_membered		//note: the implicit cast is static determined. 
						: 
						bit.expr.Call.CreateNeg(x.Key) as bit.ExprI_membered
				)
			)
			
			;
		}


		static public bit.expr.simple.set.op.Conjunct.Call _Eval(IEnumerable<bit.VarI1> vars, IEnumerable<bool> vals) {
			var assignment = new List<bit.ExprI_membered>();

			for (int i = 0; i < vars.Count(); i++)
			{
				assignment.Add(
					vals.ElementAt(i)?((bit.expr.VarAsExpr)(vars.ElementAt(i))) as bit.ExprI_membered
						: 
						bit.expr.Call.CreateNeg(vars.ElementAt(i)) as bit.ExprI_membered
				);
				
			}

			return  bit.expr.simple.set.op.Conjunct.Call.Create(assignment);
		}

		public override string ToString()
		{
			//return string.Join(nilnul.bit.combine_.And.Instance.ToString(), this.Select(kv=> kv.Value? kv.Key: nilnul.bit.expr_.call_.unary_.NegI ));

			throw new NotImplementedException();
		}


	}
}
