using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	/// <summary>
	/// not imply means: the difference of x-y, or x holds while y not.
	/// </summary>
	static public partial class DiffX
	{
		static public bool Diff(bool x,bool y) {
			return x && (!y);
		
		}

	}
}
