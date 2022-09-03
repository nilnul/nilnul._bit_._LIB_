using nilnul.bit._proof;
using nilnul.bit.proof.be_._valid;
using nilnul.bit.proof.be_._valid._ask_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem.proposal.convert_
{
	/// <summary>
	/// is this a proof by contradiction? (反证法)
	/// </summary>
	public class ProveByContradiction
	{
		/// <summary>
		/// convert one theorem (a and !b -> 0) to (a->b)
		/// </summary>
		/// <param name="contradiction"></param>
		/// <returns></returns>
		static public ProposalI _Eval(ProposalI contradiction)
		{
			///the implementation is not necessary if we know a proof exists for the original statement given the proof for the condradicted statement. So the implementation here is used only as a symbol in the "call" wrapping the proof of the contradiction, and the call may never be evaluated.
			///the converted theorem will have a statement. and the proof may throw exception if you visit it to force it to materialize.
			throw new NotImplementedException();
		}
	}
}
