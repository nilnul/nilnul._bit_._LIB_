using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer.rules_
{
	/// <summary>

	///
	///
	/// 
	/// </summary>
/*
In axiomatic versions of propositional logic, one usually has among the axiom schemas(where P, Q, and R are replaced by any propositions):
Axiom 1 is: P→(Q→P)
Axiom 2 is: (P→(Q→R))→((P→Q)→(P→R))
Modus ponens is: from P and P→Q infer Q

These axiom schemas are chosen to enable one to derive the deduction theorem from them easily.So it might seem that we are begging the question.However, they can be justified by checking that they are tautologies using truth tables and that modus ponens preserves truth.

From these axiom schemas one can quickly deduce the theorem schema P→P(reflexivity of implication) which is used below:
1.(P→((Q→P)→P))→((P→(Q→P))→(P→P)) from axiom schema 2 with P, (Q→P), P
2.P→((Q→P)→P) from axiom schema 1 with P, (Q→P)
3.(P→(Q→P))→(P→P) from modus ponens applied to step 2 and step 1
4.P→(Q→P) from axiom schema 1 with P, Q
5.P→P from modus ponens applied to step 4 and step 3
*/
	public class _1__
	{
	}
}
