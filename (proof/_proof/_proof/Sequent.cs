using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit._proof
{
	/// <summary>
	/// 
	/// </summary>
	///<remarks>

	/// </remarks>
	public class Sequent : _sequent_.AllA
	{
		static public nilnul.bit.ExprI1 CreateExpr(
			nilnul.bit.expr.Set1 premise, E finding
		) {

			return nilnul.bit.expr_.call_.Duo.CreateImply(
				nilnul.bit.expr.aggregate_.Conjunct.Eval(premise)
				,
				finding
			);

		}

		static public void Vow(
			nilnul.bit.expr.Set1 premise, E finding
		) {

			nilnul.bit.expr_.call_.duo_.imply.be_.tauto.Vow.Eval(
				nilnul.bit.expr.aggregate_.Conjunct.Eval(premise)
				,
				finding
			);

		}

		public Sequent(nilnul.bit.expr.Set1 premise, E finding )
		{
			Vow(premise,finding);
			_premise = premise;
			_finding = finding;

		
		}
		private ExprI1 _finding;
		public override ExprI1 finding
		{
			get
			{
				return _finding;
				//throw new NotImplementedException();
			}
		}

		private nilnul.bit.expr.Set1 _premise;
		public override nilnul.bit.expr.Set1 premise
		{
			get
			{
				return _premise;
				//throw new NotImplementedException();
			}
		}
		
	}
}
