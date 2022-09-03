using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit._theorem._proposal.statement_
{
	public class MultiHypothesis : _statement_.AllI
	{
		public MultiHypothesis(expr.Set1 presumption, ExprI1 conclusion )
		{
			_postulates = presumption;
			_consequent = conclusion;
		}

		public MultiHypothesis(
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

		static public MultiHypothesis _CreateFroExprs(params ExprI1[] exprs_nonEmpty) {

			return new MultiHypothesis(exprs_nonEmpty.Take(exprs_nonEmpty.Count() - 1), exprs_nonEmpty.Last());

		}

		static public MultiHypothesis CreatePositSingle(ExprI1 presumption, ExprI1 conclusion) {

			return new MultiHypothesis(new[] { presumption}, conclusion);

		}



		private ExprI1 _consequent;
		public ExprI1 consequent
		{
			set {
				_consequent = value;
			}
			get
			{
				return _consequent;
				throw new NotImplementedException();
			}
		}

		private expr.Set1 _postulates;
		public expr.Set1 postulates
		{
			set {
				_postulates = value;
			}
			get
			{
				return _postulates;

				throw new NotImplementedException();
			}
		}

		static public ExprI1 ComputeAntecedent(expr.Set1 _postulates) {
				return nilnul.bit.expr.aggregate_.Conjunct.Eval(_postulates);

		}
		static public ExprI1 ComputeAntecedent(params ExprI1[] _postulates) {
				return nilnul.bit.expr.aggregate_.Conjunct.Eval(_postulates);

		}

		public ExprI1 antecedent
		{
			get
			{
				return nilnul.bit.expr.aggregate_.Conjunct.Eval(_postulates);
				//throw new NotImplementedException();
			}
		}

		
	}
}
