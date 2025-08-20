using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.theorem.convert_
{
	/// <summary>
	/// Given a set of inference rules.
	/// From
	///		1) {A1,A2, ...,A[n]} |= B -> C ,
	/// 
	///we can get:
	///		2) {A1, A2, ...,A[n],  B} |= C
	/// 
	/// 
	///To verify this, we now consider 2). 
	///		following the same inference rules of (1), from {A1, ... ,A[n]}we can get 
	///		|= B-> C. 
	///		now we add B-> C to our suppositions.
	///		B->C, B so C   (by natural inference)
	/// 
	/// Note we here don't say: from 2) , to get one.
	/// 
	/// 
	/// 
	/// </summary>
	/// 
	/*
	 The resolution theorem[edit]

The resolution theorem is the converse of the deduction conversion. It follows immediately from modus ponens which is the elimination rule for implication

		 */

	/*
	 The converse of DT is also valid:
If the sequence ϕ 1   ,   ϕ 2   ,   . . . ,   ϕ n   ⊢ χ → ψ    has been demonstrated, then it is also possible to demonstrate the sequence ϕ 1   ,   ϕ 2   ,   . . . ,   ϕ n   ,   χ ⊢ ψ    
in fact, the validity of the converse of DT is almost trivial compared to that of DT:
If ϕ 1   ,   . . . ,   ϕ n   ⊢ χ → ψ   then 

		ϕ 1   ,   . . . ,   ϕ n   ,   χ ⊢ χ → ψ   
 ϕ 1   ,   . . . ,   ϕ n   ,   χ ⊢ χ   
 
		and from (1) and (2) can be deduced 3: ϕ 1   ,   . . . ,   ϕ n   ,   χ ⊢ ψ    by means of modus ponens, Q.E.D.
The converse of DT has powerful implications: it can be used to convert an axiom into an inference rule. For example, the axiom AND-1,
⊢ ϕ ∧ χ → ϕ   
can be transformed by means of the converse of the deduction theorem into the inference rule
ϕ ∧ χ ⊢ ϕ    
which is conjunction elimination, one of the ten inference rules used in the first version (in this article) of the propositional calculus.


	 */
	public class PreposePremise
	{

	}

	/*
	 
		/// for Pi (Alpha) -> Pi{A1,A2, ...,A[n]} -> ( B -> C)
	/// 	 by replacement (or rules derived) (the rule is: X->Y->Z = X and Y ->Z), (we neednot apply the rule repeatedly): Pi{A1,A2, ...,A[n]} -> ( B -> C) = Pi{A1,A2, ...,A[n], B} ->  C
	///	we get:  Pi (Alpha) -> Pi{A1,A2, ...,A[n], B} ->  C
	///	
	/// so Pi (Alpha) -> Pi{A1,A2, ...,A[n]} -> ( B -> C) = Pi (Alpha) -> Pi{A1,A2, ...,A[n], B} ->  C
	/// 
	/// So Pi (Alpha) -> Pi{A1,A2, ...,A[n], B} ->  C is also tauto.
	/// So Pi (Alpha) => Pi{A1,A2, ...,A[n], B} ->  C .
	/// So Pi{A1,A2, ...,A[n], B} |= C， under Axiom Alpha
	/// 
 
	 */
}
