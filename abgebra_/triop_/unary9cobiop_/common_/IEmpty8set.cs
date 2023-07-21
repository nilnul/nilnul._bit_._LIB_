using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra_.common_
{
	/// <summary>
	/// no nary ops; only: not, and ,or. 
	/// </summary>
	/// 
	/// x -> !x
	/// x & !x -> 0
	///		, x & !x -> (()->0)
	///			, can we take the right hand side only? it's: ()->0, and now we can clain that we have generated: ()->0, a nary operator.
	///			, the variables that wouldnot change result, or discards like "_" in c#, are removed.
	///			
	internal class INonnary
	{
	}
}
