using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.set_.complete_
{
	/// <summary>
	/// not, and, or, and the nullary operator:[0]
	/// </summary>
	/// <remarks>
	/// how about 0,1?</remarks>
	public interface NormalI
	{
		/// with [0] the nullary op, we can get [1] by composite:
		///		[0] ====>  not
		///		nullary operator is not composible in that they didn't take any input.
		///		
		///if we can create a var or literal out of nowhere, then we don't need the nullay op.

	}
}
