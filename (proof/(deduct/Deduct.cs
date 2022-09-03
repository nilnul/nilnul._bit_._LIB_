using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	/// <summary>
	/// A language L of tuple4:
	/// 
	///		Alphabet
	///		Operators or functions
	///		a finite set of transformation rules that are called inference rules.
	/// 
	///		a finite set of initial points that are called axioms when they receive logical interpretations.
	/// </summary>
	/// <remarks>
	/// A formal or mathematical system consists of a collection of symbols (such as 2, 4, + and =), syntax rules that describe how symbols may be combined to form a legal expression(called a well-formed formula or wff, pronounced “whiff”), some starting wffs called axioms, and inference rules that describe how theorems may be derived(proved) from the axioms.A theorem is a mathematical fact such as 2 + 2 = 4. Strictly speaking, even an obvious fact such as this must be proved from axioms to be formally acceptable to a mathematician.
	/// 
	/// 
	/// A metatheorem is usually a statement that is too general to be directly provable in a 	theory.For example, “if n1, n2, and n3 are integers, then n1 + n2 + n3 is an integer” is a theorem of number theory.But “for any integer k > 1, if n1, . . . , nk are integers, then n1 + . . . + nk is an integer” is a metatheorem, in other words a family of theorems, one for every k.The reason it is not a theorem is that the general sum n1 + . . . + nk (as a function of k) is not an operation that can be defined directly in number theory. 
	/// 
	/// 
	/// A formal mathematical system contains (1) the rules for constructing syntactically correct wffs, (2) a list of starting wffs called axioms, and(3) one or more rules prescribing how to derive new wffs, called theorems, from the axioms or previously derived theorems.An example of such a system is contained in Metamath’s set theory database, which defines a formal system from which all of standard mathematics can be derived.Section 2.2.1 steps you through a complete example of a formal system, and you may want to skim it now if you are unfamiliar with the concept.
	/// </remarks>
	/// <remarks>
	///a collection of exprs; this collection may be and usually is coutable.
   ///  such collection implies a collection of var, for varAsExpr is expr.
   ///   this collection usually defined as WFF (including finite number of vars, no.op.True, no.op.False, Not,And,Or, Imply, Iff), so implies 1,0, for  1,0 is special kind of exprs - the no.call .
   /// 
   /// 
   /// a finite subset of this collection is defined as axioms - we assert they are true. axioms may be empty, as is the case of natural deduction.
   /// 
   /// some inference rules: transform from one expr to another.   for natural deduction, they are the substitue and replace rule, where substitue convert one theorem to another, replace convert one func to a theorem  f(x) == f(y) if x==y
   /// 
   /// 
   /// The a proof is a sequence of deduction increasing theorems till it contains what to prove, where:
   /// each deduction is a transfrom from one collection of theorem to a new, augmented collection of theorem.
   /// the first decution's input is the theorem. the last deduction is a collection with the newly added theorm that is also the conclusion.
   /// the deduction get some of the input theorem and infers a theorem, which should be new,  and add it to the theorems.
	/// </remarks>

	public class Sys
	{
		private nilnul.bit.expr.In2nI _exprs;

		public nilnul.bit.expr.In2nI exprs
		{
			get { return _exprs; }
			set { _exprs = value; }
		}

		private nilnul.bit.expr.Set _assumptions;

		public nilnul.bit.expr.Set assumptions
		{
			get { return _assumptions; }
			set { _assumptions = value; }
		}

		private List<Func<ExprI_membered,ExprI_membered>> _derives;	//finite set of transforms. note for natural deduction, the candidate are coutable, but we should use only finite. the remained can only be proven on demand.

		public List<Func<ExprI_membered,ExprI_membered>> derives	//apply the transform once on the _assumptions, we get a new Sys. we can apply a string of such transforms.
		{
			get { return _derives; }
			set { _derives = value; }
		}

	}
}
