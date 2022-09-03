using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer.rules.be_
{
	/// <summary>
	////A set of rules can be used to infer any valid conclusion if it is complete, while never inferring an invalid conclusion, if it is sound.A sound and complete set of rules need not include every rule in the following list, as many of the rules are redundant, and can be proven with the other rules.

	/// </summary>
	/// 

	/*
	 No theory containing at least the peano axioms can prove its own consistency (proven by Gödel). But there can be a stronger theory proving the consistency of the weaker theory. The catch is, to prove the consistency of the stronger theory, you need an even stronger one.

ZFC is believed to be consistence and can be used to prove the consistency of PA.

To be both consistent and complete, a theory must be weaker than PA, for example the Presburger arithmetic has been proven to be both complete and consistent.

	 */

	/*
	 If G implies A, then G proves A.
	 */
	public class Complete
	{
	}
}
