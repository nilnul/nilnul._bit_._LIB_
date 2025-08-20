using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.sys._proof.rule.eg
{


	public class Substitue:RuleI
	{
		private nilnul.bit.ExprI_membered _theorem;

		public nilnul.bit.ExprI_membered theorem
		{
			get { return _theorem; }
			set { _theorem = value; }
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
				return nilnul.bit.expr.op.Substitute.Singleton.eval(_theorem, _varExprMapping);
			}
		}



	}
}
