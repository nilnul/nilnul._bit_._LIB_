using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal._statement_
{

	/// <summary>
	/// Logically, many theorems are of the form of an indicative conditional: if A, then B. Such a theorem does not assert B, only that B is a necessary consequence of A. In this case A is called the hypothesis of the theorem (note that "hypothesis" here is something very different from a conjecture) and B the conclusion (formally, A and B are termed the antecedent and consequent). 
	/// </summary>
	public interface AllI:AntecedentI, ConsequentI
	{

	}
}
