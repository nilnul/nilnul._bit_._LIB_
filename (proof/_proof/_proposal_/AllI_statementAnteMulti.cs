using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit._theorem._proposal;

namespace nilnul.bit._theorem._proposal_
{
	/// <summary>
	/// a general proposition not self-evident but proved by a chain of reasoning; a truth established by means of accepted truths.
	/// many theorems are of the form of an indicative conditional: if A, then B. Such a theorem does not assert B, only that B is a necessary consequence of A. In this case A is called the hypothesis of the theorem (note that "hypothesis" here is something very different from a conjecture) and B the conclusion (formally, A and B are termed the antecedent and consequent). 
	/// A theorem and its proof are typically laid out as follows:
	///Theorem(name of person who proved it and year of discovery, proof or publication).Statement of theorem(sometimes called the proposition).Proof.Description of proof.End mark.
	///The end of the proof may be signalled by the letters Q.E.D. (quod erat demonstrandum) or by one of the tombstone marks "□" or "∎" meaning "End of Proof", introduced by Paul Halmos following their usage in magazine articles.
	///The statements of the language are strings of symbols and may be broadly divided into nonsense and well-formed formulas. A set of deduction rules, also called transformation rules or rules of inference, must be provided. These deduction rules tell exactly when a formula can be derived from a set of premises. The set of well-formed formulas may be broadly divided into theorems and non-theorems. However, according to Hofstadter, a formal system often simply defines all its well-formed formula as theorems.[

	/// </summary>
	public interface AllI_statementAnteMulti:_proposal_.ProofI, _proposal_.StatementI_anteMulti
	{

	}

	public abstract class AllA : AllI_statementAnteMulti
	{
		public abstract _proposal.ProofI proof { get; }
		public abstract _proposal.StatementI_anteMulti statement { get; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
