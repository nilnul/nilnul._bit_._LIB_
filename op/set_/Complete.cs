using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.set_
{
	/// <summary>
	/// if any func can be expressed by these ops.
	/// eg:
	///		neg(x )=  (x NAND x)
	///		and(x,y) = (x NAND y ) NAND (x NAND y)
	///
	///  so {NAND} is complete
	///  
	/// </summary>
	class Complete
	{
	}
}
