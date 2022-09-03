using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{

	/// <summary>
	/// 
	/// The turnstile represents a binary relation. It has several different interpretations in different contexts:
	///	In metalogic, the study of formal languages; the turnstile represents syntactic consequence(or "derivability"). This is to say, that it shows that one string can be derived from another in a single step, according to the transformation rules(i.e.the syntax) of some given formal system.[6] As such, the expression
	///P ⊢ Q   
	///P ⊢ Qmeans that Q is derivable from P in the system.Consistent with its use for derivability, a "⊢" followed by an expression without anything preceding it denotes a theorem, which is to say that the expression can be derived from the rules using an empty set of axioms.As such, the expression ⊢ Q   means that Q is a theorem in the system.
	/// </summary>
	/// <remarks>
	/// 
	/// Syntactic accounts of logical consequence rely on schemes using inference rules. For instance, we can express the logical form of a valid argument as:
	////	All 	A are	B
	////All	C  are A
	////Therefore, all		C are	B

	////This argument is formally valid, because every instance of arguments constructed using this scheme are valid.

	////This is in contrast to an argument like "Fred is Mike's brother's son. Therefore Fred is Mike's nephew." Since this argument depends on the meanings of the words "brother", "son", and "nephew", the statement "Fred is Mike's nephew" is a so-called material consequence of "Fred is Mike's brother's son," not a formal consequence. A formal consequence must be true in all cases, however this is an incomplete definition of formal consequence, since even the argument "P   {\displaystyle P}  P is Q   {\displaystyle Q}  Q's brother's son, therefore P   {\displaystyle P}  P is Q   {\displaystyle Q}  Q's nephew" is valid in all cases, but is not a formal argument.[1]

	/// </remarks>
	public class Entail
	{

	}

	public interface EntailI
	{
		//antecedent	//premise
		//apodosis	//consequent //conclusion
	}
}
