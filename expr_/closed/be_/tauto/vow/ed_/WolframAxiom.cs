using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit.expr.tauto.asserted.eg
{
	/// <summary>
	/// this single axiom can, by some rules (substitue, for example), infer out all tautologies.
	/// 
	/// Maybe (maybe not) this can be proven by:
	///  proving that  x nand y   = the sum of minterms.
	/// 
	/// </summary>
	public class WolframAxiom:nilnul.bit.expr.tauto.Asserted
	{

		public WolframAxiom( ):base( nilnul.bit.expr.eg.WolframAxiom.Singleton)
		{

		}
	}
}
