using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op
{
	[Obsolete()]
	public partial class Nand:BinaryOpI
	{
		public bool exec(bool a, bool b)
		{
			return !(a&&b);
		}

		static public bool Exec(bool a, bool b) { 
			return !(a&&b);
		}


	}
}
