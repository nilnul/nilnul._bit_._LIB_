using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit._theorem._proposal._statement_
{

	/// <summary>
	/// Logically, many theorems are of the form of an indicative conditional: if A, then B. Such a theorem does not assert B, only that B is a necessary consequence of A. In this case A is called the hypothesis of the theorem (note that "hypothesis" here is something very different from a conjecture) and B the conclusion (formally, A and B are termed the antecedent and consequent). 
	/// </summary>
	public interface AllI_antecedentInSet:Antecedent_setI, ConsequentI
	{

	}

	public abstract class AllA : AllI_antecedentInSet
	{
		public abstract Set1 antecedent { get; }
		public abstract ExprI1 consequent { get; }

		public override string ToString()
		{
			return $"{antecedent}{_statement_.ThereforeInfixSymbol.Default}{consequent}";
		}
	}
}
