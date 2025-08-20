using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof.infer.be_
{
	/// It is not required for a valid argument to have premises that are actually true, but to have premises that, if they were true, would guarantee the truth of the argument's conclusion. Valid arguments must be clearly expressed by means of sentences called well-formed formulas (also called wffs or simply formulas).
	/// <summary>
	///A formula of a formal language is a valid formula if and only if it is true under every possible interpretation of the language. In propositional logic, they are tautologies.
	/// 
	/// </summary>
	/// <remarks>
	/// eg:
	///		A -> B
	///		B -> C
	///		there4, A -> C
	///		
	/// </remarks>
	/// eg:
	///		premises:
	///			All men are mortal. (True)
	///			Socrates is a man. (True)
	///		Therefore, Socrates is mortal. (True)
	///	eg:
	///		All cups are green. (False)
	///		Socrates is a cup. (False)
	///		Therefore, Socrates is green. (False)
	///	,even though the above results a false statement, the overall infer|deduce is valid;
	/// 
	internal class IValid
	{
	}
}
