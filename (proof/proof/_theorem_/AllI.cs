using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit._theorem._proposal;

namespace nilnul.bit.proof._theorem_
{

	public interface AllI:StatementI, ProofI
	{
	}

	public abstract class AllA : AllI
	{
		public abstract _theorem._proposal.ProofI proof { get; }
		public abstract StatementI_anteMulti statement { get; }

		public override string ToString()
		{
			return $"{statement.antecedent}{bit.proof._theorem_.ProvenInfixSymbol.Default}{statement.consequent}";
		}
	}
}
