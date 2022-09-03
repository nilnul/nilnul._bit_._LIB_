using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.theorem.re_
{
	/// <summary>
	/// we can get one theorem to another.
	/// 
	/// The following two theorems will hold or not hold simultaneouly
	/// 1) {A1,A2, ...,A[n]} |= B -> C ,
	/// 
	/// 2) {A1, A2, ...,A[n],  B} |= C
	/// 
	/// To prove this, let's supposing the axiom is Alpha
	/// from 1) we know : Pi (Alpha) => Pi{A1,A2, ...,A[n]} -> ( B -> C)
	/// 
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
	/// 
	/// </summary>
	public class AppendSubPremise
	{
	}
}
