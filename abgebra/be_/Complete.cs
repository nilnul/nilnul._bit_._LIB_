using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra.be_
{
	/// <see cref="bit.op.set.be_.PartiallyComplete"/>
	/// regard <see cref="bit.abgebra"/> as a set of ops, including nary ops, not as a set of operands with operators.
	/// eg:
	///		{0, xor,and}
	///	each operator is regarded as an assumption|axiom, like the assumptions for a proof or the production rules for computer language deduction.
	///	each operator acts as a derivation rule, and we can get a result from it.
	///
	/// The the questions is:
	///		can we deduce all expressions in the sense of up to "equilivalence", that is: can we find an expression derived that is equivalent to any expression?
	///	Asking the question this way would reduce the delicate ambiguity on whether we should inlucde 0 or 1 in the set of operators we are dealing with.
	///
	/// eg:
	///		{1,xor,and}
	///	 for any set of vars such as {x,y}, can we duduce all expressions involving x,y,upto equivalence?
	///		{1,xor,and} is our derival rules;
	///		{x,y} is now the starting axioms or rules;
	///	  now let's try whether we can derive 0
	///		1 xor x=!x
	///		x & 1x =0
	///		note here we can derive both 0 and 1. So this is not a normal proof, but a syntax for language.
	///	for {}, that is no vars, we shall derive 0 and 1.
	///		we already have 1. so let's try 0.
	///		1 ^ 1 =0
	///		
	/// eg:
	///		{nand}
	///		?can we take the output as the input? thus regard the op as a two seperate parallel ops, the outpt are forked: one to the input, one to be the continued output.
	///		?as lang, we require that there exists at least one symbol which can be taken as the initial symbol.
	///			, if the symbols are empty, by vacuous derivation, we can derive any expr;??
	///		? if the vars are empty, the expression for empty vars can be 0, or 1.
	///
	/// if we regard the set of vars as not the symbols in lang syntax, but the presumptions in proof,
	///		,the projection of (x,y) to (x) to () is natural, as we can always drop one maxterm from conjunction x^y, and get x, then ()
	///		, the conjunciton of () is 1. the compoennt in precedent can be written directly as subsequent;
	/// <summary>
	/// set of (operator|scala)Es, including constant|0aryOperator,
	/// a nonempty set of vars,
	/// can we derive all expression,up to equivalence ,of some such vars ?
	/// for tautology, we can transform that expr to 0 or 1, up to equivalence.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	internal class Complete
	{
	}
}
