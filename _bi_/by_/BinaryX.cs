using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	static public partial class BinaryX
	{
		static public bool Gt(bool x, bool y) { 
			return x & !y;
		}
		/// <summary>
		/// choose the arg0
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool C0(bool x, bool y) { 

			return x;
		
		}

		/// <summary>
		/// Projection operator.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public bool P0(bool x, bool y) {
			return C0(x, y);
		}



	}
}
