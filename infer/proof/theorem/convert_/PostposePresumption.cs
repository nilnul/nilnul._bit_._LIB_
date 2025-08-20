using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.theorem.convert_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// also known as: 
	/// 
	///		deduction theorem
	///		conditional proof,
	/// </remarks>
	/// 
	/// from: 1) {A1, A2, ...,A[n],  B} |-  C
	/// 
	/// to: 2) {A1,A2, ...,A[n]} |- B -> C ,
	/// 
	/// 
	/// 
	/// if the first is theorem, is the second a theorem? For a natural inference system, this is true; but for non-natural, this is a question.
	/// 
	/// 1) means a set of causes result to C.
	/// 2) means some of the causes will derive that B implies C. implies means B can solely induce C, which might be not true  (WYT is not sure about this, can someone give WYT an exmaple.). Note the B-> C uses -> not |-; the former is a natural system sign while we are in a non-natural system.
	/// 
	/// Note that B -> C is a boolean expression. " ...|- B -> C" means B -> C is assumed; but 0 can also be assumed, contingency can also assumed, and tautology can also be assumed.
	/// If we get 2) from 1), we may have assumed too much, thus changed or over bloated the axioms.
	/// 
	/// 
	/// 
	/// 
	///note: in 2), we may lack an inference rule to get the consuqent from antecequents.
	/// 
	/// 
	/// 
	/// 
	/*
	The deduction theorem states that if a formula B is deducible from a set of assumptions Δ ∪ { A }   , where A is a closed formula, then the implication A → B is deducible from Δ   . In symbols, Δ ∪ { A } ⊢ B   implies Δ ⊢ A → B  . In the special case where Δ     is the empty set, the deduction theorem shows that { A } ⊢ B    implies ⊢ A → B   .

	The deduction theorem holds for all first-order theories with the usual deductive systems for first-order logic.However, there are first-order systems in which new inference rules are added for which the deduction theorem fails.[2] Most notably, the deduction theorem fails to hold in Birkhoff-von Neumann quantum logic, because the linear subspaces of a Hilbert space form a non-distributive lattice.

		The deduction rule is an important property of Hilbert-style systems because the use of this metatheorem leads to much shorter proofs than would be possible without it. Although the deduction theorem could be taken as a primitive rule of inference in such systems, this approach is not generally followed; instead, the deduction theorem is obtained as an admissible rule using the other logical axioms and modus ponens. In other formal proof systems, the deduction theorem is sometimes taken as a primitive rule of inference. For example, in natural deduction, the deduction theorem is recast as an introduction rule for "→".

		In general, the classical deduction theorem doesn't hold in paraconsistent logic. However, the following "two-way deduction theorem" does hold in one form of paraconsistent logic:[3]
⊢ E → F    if and only if (E ⊢ F    and ¬ F ⊢ ¬ E   )
that requires the contrapositive inference to hold in addition to the requirement of the classical deduction theorem.


		 
		 */


	/*
	 It may seem redundant to have two notions of inference in this case, ⊢ and →. In classical propositional logic, they indeed coincide; the deduction theorem states that A ⊢ B if and only if ⊢ A → B. There is however a distinction worth emphasizing even in this case: the first notation describes a deduction, that is an activity of passing from sentences to sentences, whereas A → B is simply a formula made with a logical connective, implication in this case. Without an inference rule (like modus ponens in this case), there is no deduction or inference. This point is illustrated in Lewis Carroll's dialogue called "What the Tortoise Said to Achilles".[3]

For some non-classical logics, the deduction theorem does not hold. For example, the three-valued logic Ł3 of Łukasiewicz can be axiomatized as:[4]
(CA1) ⊢ A → (B → A)
(LA2) ⊢ (A → B) → ((B → C) → (A → C))
(CA3) ⊢ (¬A → ¬B) → (B → A)
(LA4) ⊢ ((A → ¬A) → A) → A
(MP)  A, A → B ⊢ B


This sequence differs from classical logic by the change in axiom 2 and the addition of axiom 4. The classical deduction theorem does not hold for this logic, however a modified form does hold, namely A ⊢ B if and only if ⊢ A → (A → B).[5]


	 */

	/*

	 If the sequence ϕ 1   ,   ϕ 2   ,   . . . ,   ϕ n   ,   χ ⊢ ψ    has been demonstrated, then it is also possible to demonstrate the sequence ϕ 1   ,   ϕ 2   ,   . . . ,   ϕ n   ⊢ χ → ψ   .
This deduction theorem (DT) is not itself formulated with propositional calculus: it is not a theorem of propositional calculus, but a theorem about propositional calculus. In this sense, it is a meta-theorem, comparable to theorems about the soundness or completeness of propositional calculus

	 */


	/*
In axiomatic versions of propositional logic, one usually has among the axiom schemas (where P, Q, and R are replaced by any propositions):
Axiom 1 is: P→(Q→P)
Axiom 2 is: (P→(Q→R))→((P→Q)→(P→R))
Modus ponens is: from P and P→Q infer Q

These axiom schemas are chosen to enable one to derive the deduction theorem from them easily. So it might seem that we are begging the question. However, they can be justified by checking that they are tautologies using truth tables and that modus ponens preserves truth.

From these axiom schemas one can quickly deduce the theorem schema P→P (reflexivity of implication) which is used below:
1.(P→((Q→P)→P))→((P→(Q→P))→(P→P)) from axiom schema 2 with P, (Q→P), P
2.P→((Q→P)→P) from axiom schema 1 with P, (Q→P)
3.(P→(Q→P))→(P→P) from modus ponens applied to step 2 and step 1
4.P→(Q→P) from axiom schema 1 with P, Q
5.P→P from modus ponens applied to step 4 and step 3

Suppose that we have that Γ and H prove C, and we wish to show that Γ proves H→C. For each step S in the deduction which is a premise in Γ (a reiteration step) or an axiom, we can apply modus ponens to the axiom 1, S→(H→S), to get H→S. If the step is H itself (a hypothesis step), we apply the theorem schema to get H→H. If the step is the result of applying modus ponens to A and A→S, we first make sure that these have been converted to H→A and H→(A→S) and then we take the axiom 2, (H→(A→S))→((H→A)→(H→S)), and apply modus ponens to get (H→A)→(H→S) and then again to get H→S. At the end of the proof we will have H→C as required, except that now it only depends on Γ, not on H. So the deduction step will disappear, consolidated into the previous step which was the conclusion derived from H.

To minimize the complexity of the resulting proof, some preprocessing should be done before the conversion. Any steps (other than the conclusion) which do not actually depend on H should be moved up before the hypothesis step and unindented one level. And any other unnecessary steps (which are not used to get the conclusion or can be bypassed), such as reiterations which are not the conclusion, should be eliminated.

During the conversion, it may be useful to put all the applications of modus ponens to axiom 1 at the beginning of the deduction (right after the H→H step).

When converting a modus ponens, if A is outside the scope of H, then it will be necessary to apply axiom 1, A→(H→A), and modus ponens to get H→A. Similarly, if A→S is outside the scope of H, apply axiom 1, (A→S)→(H→(A→S)), and modus ponens to get H→(A→S). It should not be necessary to do both of these, unless the modus ponens step is the conclusion, because if both are outside the scope, then the modus ponens should have been moved up before H and thus be outside the scope also.

Under the Curry–Howard correspondence, the above conversion process for the deduction meta-theorem is analogous to the conversion process from lambda calculus terms to terms of combinatory logic, where axiom 1 corresponds to the K combinator, and axiom 2 corresponds to the S combinator. Note that the I combinator corresponds to the theorem schema P→P.


	 */

	/*
The deduction theorem is also valid in first-order logic in the following form:
If T is a theory and F, G are formulas with F closed, and T ∪ { F } ⊢ G   {\displaystyle T\cup \{F\}\vdash G}  {\displaystyle T\cup \{F\}\vdash G}, then T ⊢ F → G   {\displaystyle T\vdash F\rightarrow G}  {\displaystyle T\vdash F\rightarrow G}.

Here, the symbol ⊢   {\displaystyle \vdash }  \vdash  means "is a syntactical consequence of." We indicate below how the proof of this deduction theorem differs from that of the deduction theorem in propositional calculus.

In the most common versions of the notion of formal proof, there are, in addition to the axiom schemes of propositional calculus (or the understanding that all tautologies of propositional calculus are to be taken as axiom schemes in their own right), quantifier axioms, and in addition to modus ponens, one additional rule of inference, known as the rule of generalization: "From K, infer ∀vK."

In order to convert a proof of G from T∪{F} to one of F→G from T, one deals with steps of the proof of G which are axioms or result from application of modus ponens in the same way as for proofs in propositional logic. Steps which result from application of the rule of generalization are dealt with via the following quantifier axiom (valid whenever the variable v is not free in formula H):
(∀v(H→K))→(H→∀vK).

Since in our case F is assumed to be closed, we can take H to be F. This axiom allows one to deduce F→∀vK from F→K and generalization, which is just what is needed whenever the rule of generalization is applied to some K in the proof of G.

	 */
	public class PostposePresumption
	{
	}
}
