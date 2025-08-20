using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.to_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ToNumX
	{
		/// <summary>
		/// 0 for false; 1 for true;
		/// as 0 is the origin, which gives birth to 1, hence 0 is for false, which is the default value of boolean type;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		indicator function
		///			used in math to convert boolean to number;
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int ToNum(this bool x) {
			return x ? 1 : 0;
		}

	


	}
}
