using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._inference_
{
	/// <summary>
	/// the premise of a sequent
	/// </summary>
	public interface AntecedentsI
	{
		/// <summary>
		/// a string of exprs. the product of this str is used in the sequent to verify the inferenceness of the expr in the sequent.
		/// 
		/// 
		/// </summary>
		/// <remarks>
		/// here we will note that why we prefer a collection as the antecedent of the statement of a theorem. Because in the process of proof, we need to check the premise of the sequent is subset of the antecedent.
		/// </remarks>
		nilnul.bit.expr.Set1 antecedents { get; }
	}
}
