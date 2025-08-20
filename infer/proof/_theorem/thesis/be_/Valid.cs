using nilnul.bit.proof.be_._valid._ask_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem.proposal.be_
{
	public class Valid
	{
		[Obsolete(nameof(Eval))]
		static public bool Eval(AskI ask, nilnul.bit._theorem._proposal.ProofI proof) {

			///note: that 0 can be in presumptions.
			///and the presumptions can be empty; in this case only tautology can be in presumptions.
			///Note: we use postulate (or suppositions with the sup as the prefix) as the name for "post-" suffixe indicates it's formed later after the premise or presumption which uses the "pre-" prefix.
			///
			var suppositions = new nilnul.bit.expr.Set1(
				ask.antecedent.hashSet
			);

			foreach (var item in proof.sequents)
			{
				nilnul.obj.set.re_._Subset.Avow(
					suppositions,   item.premise
				);	///soundness
				suppositions.add(item.finding);
			}

			return suppositions.contains(
				ask.conclusion
			);
		}
		static public bool Eval( nilnul.bit._theorem.ProposalI proposal) {

			///note: that 0 can be in presumptions.
			///and the presumptions can be empty; in this case only tautology can be in presumptions.
			///Note: we use postulate (or suppositions with the sup as the prefix) as the name for "post-" suffixe indicates it's formed later after the premise or presumption which uses the "pre-" prefix.
			///
			var suppositions = new nilnul.bit.expr.Set1(
				proposal.statement.antecedent.hashSet
			);

			foreach (var item in proposal.proof.sequents)
			{
				///todo: contextual rule checks

				nilnul.obj.set.re_._Subset.Vow(
					item.premise
					,
					suppositions
					
				);
				suppositions.add(item.finding);
			}

			return suppositions.contains(
				proposal.statement.consequent
			);
		}



	}
}
