using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal._statement_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// true statement is not necessarily included in antecedent. for in proof, we can always introduce true statement into "suppositions" by inserting sequent in the form of " {} |- trueStatement "
	/// So generally, in antecedent we only add presumptions. note the plurality of presumptionS.
	/// </remarks>

	public interface Antecedent_setI
	{
		/// <see cref="nameof(_proof._sequent_.PremiseI)"/> for why we use set instead of a single expr.
		/// <summary>
		/// Note: the element in this set is presumption. not necessarily true statement. in the process of proof, we add more presumption to this set.
		/// if the anteceden is empty, only true statement can become the consequent.
		/// </summary>
		nilnul.bit.expr.Set1 antecedent { get; }
	}
}
