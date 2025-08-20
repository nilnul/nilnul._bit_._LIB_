using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer.rules.be_
{

	/*
	 * 
	 
		 A proof system is a Formal system with logical axiom (possibly none) and rules of inference (at least one).

Some examples :

•Hilbert-style proof system : usually more than one (logical) axioms and few rules : modus ponens and generalization. See Herbert Enderton, A Mathematical Introduction to Logic (2nd ed - 2001), page 109, for a system with few axioms and only modus ponens as inference rule;


•Natural deduction : no (logical) axiom and many rules, tipically a couple for every connective. See Jan von Plato, Elements of Logical Reasoning (2013), page 31.


Other proof systems are : sequent calculus, resolution, tableaux method (or truth tree).

Regarding completeness and soundness, they are relative to a semantics suitable for the language of the proof system : truth tables for propositional calculus, mathematical strucutures for first-order logic (see e.g. Enderton, page 80).

See Enderton, page 131 : 


In this section we establish two major theorems: the soundness of our deductive calculus :


if Γ⊢φ 
Γ⊢φ
, then Γ⊨φ 
Γ⊨φ


and its completeness :


if Γ⊨φ 
Γ⊨φ
, then Γ⊢φ 
Γ⊢φ
.

Although our deductive calculus was chosen in a somewhat arbitrary way, the significant fact is that some such deductive calculus is sound and complete.

Soundness means : the proof system can derive as conclusion (φ 
φ
) only formulae that are logical consequence of the formulae contained into the set of premises (Γ 
Γ
).

Completeness means : the proof system can derive as conclusion (φ 
φ
) all the formulae that are logical consequence of the formulae contained into the set of premises (Γ 
Γ
).

Soundness implies consistency; consider the case of propositional logic : no formula and its negation are both tautologies. But the soundness of the calculus means that a formula which is not a tautology is not derivable; thus, no pair of contradictory formulae is derivable.

Regarding decidability, this property is relative to the set of formulae derivable within the calculus; the answer is positive for propositional calculus : the truth table is a (very inefficient) algorithm to verify validity (i.e.checking for "tautologuesness").

For first-order logic, the answer is negative (Enderton, page 142-145): 


ENUMERABILITY THEOREM For a reasonable language, the set of valid formulae can be effectively enumerated. [...]

It should be remarked that our proofs of enumerability cannot, in general, be strengthened to proofs of decidability. For almost all languages the set of validities is not decidable. (See Church’s Theorem.)

		 
		 */

	/*
	  Given a complete set of axioms (see below for one such set), modus ponens is sufficient to prove all other argument forms in propositional logic, thus they may be considered to be a derivative. Other argument forms are convenient, but not necessary.
	  
		Note, this is not true of the extension of propositional logic to other logics like first-order logic. First-order logic requires at least one additional rule of inference in order to obtain completeness.
	 */
	public class NotRedundant
	{
	}
}
