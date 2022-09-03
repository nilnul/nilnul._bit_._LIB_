using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// implement some members, such as "ToString", of expr
	/// </summary>
	static public class _TautoX
	{
		/// <summary>
		/// a theorm per natural deduction (only natural tauto as axioms, no other domain presumed axiom)
		/// </summary>
		/// <param name="expr"></param>
		/// <returns></returns>
		static public string Phrase(
			nilnul.bit.IExpr expr
		) {
			return $"{nilnul.bit.proof._theorem_.ProvenInfixSymbol.TripleTurnStile}{expr}";
		}
	}
}
