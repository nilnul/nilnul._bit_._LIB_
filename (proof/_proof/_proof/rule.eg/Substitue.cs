using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof.rule.eg
{


	public class Substitue:RuleI
	{
		/// <summary>
		/// not theorem, but the inference rule; and the var are meta var for expr.
		/// </summary>
		private nilnul.bit.ExprI_membered _inferRule;

		public nilnul.bit.ExprI_membered inferRule
		{
			get { return _inferRule; }
			set { _inferRule = value; }
		}

		/// <summary>
		/// note: the expr can be 1, or 0
		/// </summary>

		private nilnul.bit.expr.set.Substitution _varExprMapping;

		public nilnul.bit.expr.set.Substitution varExprMapping
		{
			get { return _varExprMapping; }
			set { _varExprMapping = value; }
		}


		public nilnul.bit.ExprI_membered result {
			get {
				return nilnul.bit.expr.op.Substitute.Singleton.eval(_inferRule, _varExprMapping);
			}
		}



	}
}
