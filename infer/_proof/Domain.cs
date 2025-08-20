using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof
{
	/// <summary>
	/// a domain of knowledge will establish:
	///		1) a collection of axioms. Axioms can be regarded as vars(or references to various objects) of certain types. later, each of the vars will be asserted to be equal to an logic expression, the meaning of which is expanded in next step.
	///		for example in geometry, we can have var1|Line#1 and var2|Line#2, which are here or later defined as instances of two lines.
	///		2) a collection of rules: we can derive another theorem from existant theorems. A |- B means A derives B; inference is a func that results such derivation.
	///		We can have a such rule: Var defined in step1 can mean|(be logically-equivalent to) an expression; this rule is what we say in step1 about how meaning of var is defined .
	///		for example in geometry, we can infer from "line 1 and line 2 are not incident or crossed" to "line 1 and line2 are parallel".
	///		vars in step1 can be regarded as special case of inference rule.  "|-A" means A is an axiom
	/// </summary>
	interface IDomain
	{
	}
}
