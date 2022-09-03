using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit._proof._sequent_
{
	/// <summary>
	/// A ⊢  B. where A must be a theorem, A => B. 
	/// For each sequent, we have two states:
	/// the end state is a collection of theorems; this collection is usually larger than the start state.
	/// Note: this sequent is a little different from the sequent defined in sequent calculus. we may name outs as inference, which follows some _inference rules (this rules are in fact imply tautologies)
	/// </summary>
	/// <remarks>
	/// 	///the difference between A => B and A ⊦ B is
	///1) in the latter, A has to be true. (If A is false, the former holds. But in the latter, A is false is not considered; so there is an assertion here: A is assumed true. )
	///2) in the latter, A has to be among the "presumptions". This is in fact an extension of 1).
	///3) in the latter, we have to follow some rule. the rule is in fact in the form of X=>Y. in the latter, A=>B, and A is among the presumptions given.
	/// 	4) 
	/// 		4.1) for A =>B, for example:  p & !p -> Q 是定理，并不代表 Q 是定理。 
	/// 	只有当 p 和 !p 都是定理的时候，p & !p -> Q 才可以写为 p & !p => Q. 
	/// 		4.2) for A ⊦ B, we know that B is also a finding.


	/// </remarks>
	public interface AllI:
		PremiseI
		,
		
		FindingI
	{

	}

	public abstract class AllA : AllI
	{
		public abstract ExprI1 finding
		{
			get
			;
		}

		public abstract Set1 premise
		{
			get;
		}

		public override string ToString()
		{
			return $"{premise}{_sequent_.ThereforeInfix_.Default}{finding}";
		}
	}
}
