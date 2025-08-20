using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit._theorem._proposal;
using nilnul.bit._theorem._proposal._statement_;

namespace nilnul.bit._theorem
{
	/// <summary>

	/// </summary>
	public abstract class ProposalA : _proposal_.AllI_statementAnteUni
	{
		public ProposalA(StatementI statement, nilnul.bit._theorem._proposal.ProofI proof)
		{
			_statement = statement;
			_proof = proof;
		}

		private nilnul.bit._theorem._proposal.ProofI _proof;
		public nilnul.bit._theorem._proposal.ProofI proof
		{
			get
			{
				return _proof;
				throw new NotImplementedException();
			}
		}

		private StatementI _statement;

		public StatementI statement
		{
			get
			{
				return _statement;
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return $"{_statement.antecedent}{_proposal_.ProveInfixSymbol.Default}{_statement.consequent}";
		}
	}
}
