using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.tauto
{
	/// <summary>
	/// for any tautology expr, say, x | y (==) y|x, 
	/// we can substitue a var with an expr A, so we get A|y (--) y|A, and this is still tauto.
	/// We can further substitue a var with an expr B, we can get A|B (==) B|A. This is a computation rule.
	/// </summary>
	interface SubstituteI
	{
	}
}
