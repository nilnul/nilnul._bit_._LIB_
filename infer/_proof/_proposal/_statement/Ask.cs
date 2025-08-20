using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit.proof.be_._valid
{
	public class Ask : _ask_.AskI
	{
		public Ask(expr.Set1 presumption, ExprI1 conclusion )
		{
			_presumption = presumption;
			_conclusion = conclusion;
		}

		public Ask(
			IEnumerable<ExprI1> presumption
			,
			ExprI1 conclusion
			
		):this(
			new Set1(presumption)
			,
			conclusion
		)
		{

		}

		static public Ask _CreateFroExprs(params ExprI1[] exprs_nonEmpty) {

			return new Ask(exprs_nonEmpty.Take(exprs_nonEmpty.Count() - 1), exprs_nonEmpty.Last());

		}

		static public Ask CreatePositSingle(ExprI1 presumption, ExprI1 conclusion) {

			return new Ask(new[] { presumption}, conclusion);

		}



		private ExprI1 _conclusion;
		public ExprI1 conclusion
		{
			set {
				_conclusion = value;
			}
			get
			{
				return _conclusion;
				throw new NotImplementedException();
			}
		}

		private expr.Set1 _presumption;
		public expr.Set1 antecedent
		{
			set {
				_presumption = value;
			}
			get
			{
				return _presumption;
				throw new NotImplementedException();
			}
		}

		
	}
}
