using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit._theorem._proposal.statement_
{
	/// <summary>
	/// this is used to act as the result when we convert the statement of the original theorem to, for proving using contradiction
	/// </summary>
	public class ContraConsequent : _statement_.AllI
	{
		public ContraConsequent(ExprI1 originalAntecedent, ExprI1 originalConsequent )
			
		{
			_originalAntecedent = originalAntecedent;
			_originalConsequent = originalConsequent;
		}

		public ContraConsequent(StatementI statement):this(
			statement.antecedent, statement.consequent
		)
		{

		}


		private ExprI1 _originalConsequent;
		public ExprI1 originalConsequent
		{
			set {
				_originalConsequent = value;
			}
			get
			{
				return _originalConsequent;
				throw new NotImplementedException();
			}
		}

		private ExprI1 _originalAntecedent;
		public ExprI1 originalAntecedent
		{
			set {
				_originalAntecedent = value;
			}
			get
			{
				return _originalAntecedent;

				throw new NotImplementedException();
			}
		}



		public ExprI1 antecedent
		{
			get
			{
				return MultiHypothesis.ComputeAntecedent(
					_originalAntecedent
					,
					nilnul.bit.expr_.call_.Mono.CreateNeg(_originalConsequent)
				);
				//throw new NotImplementedException();
			}
		}

		public ExprI1 consequent
		{
			get
			{
				return nilnul.bit.expr_.call_.No.CreateNil();
				throw new NotImplementedException();
			}
		}
	}
}
