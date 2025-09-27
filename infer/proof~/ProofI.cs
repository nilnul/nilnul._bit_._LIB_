using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal
{
	/// <summary>
	/// a proof is a collection of Inference; Inference is an imply tautology whose precedent must be true according to the theorems that's an increasing collection of true statements.
	/// a proof can also be understood as a state machine; each state is a collection of theorems; the final state contains what to prove.
	/// Proof is one way to determine whether one imply expr is tauto.
	/// </summary>
	public interface ProofI:_proof_.AllI
	{


	}
}
