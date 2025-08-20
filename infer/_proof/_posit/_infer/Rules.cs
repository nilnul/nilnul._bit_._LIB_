using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer
{
	/// <summary>
	/// the rules used to justify an inference.
	/// </summary>
	/// <remarks>
	/// If this is a natural inference system, then every implication tautology is a rule; if this is an axiomatic inference system, then every implication tautology is a rule, and also we have some other rules as axioms or theorems, which is a higher order system above the theorem proof..
	/// 
	/// In natural system, the effect is true; in non-natural system, the effect holds (satisfiable, but sometime also contradictive, not necessarily tautology)
	/// 
	/// In this project , we only deal with natural inference.
	/// non-natural inference will be discussed after proposition logic, and will be after a specific concrete case of non-natural inference of a certain domain of discipline of science.
	/// for example, production rules are different from natural rules.
	/// </remarks>
	/// there must be at least one rule in rules. (we can have empty axioms, but not empty rules.)
	/// Note: proof can be blank to deduce an axiom from axioms. So the inference rule: Axiom -> Axiom is not necessary.

	public class Rules
	{
	}
}
