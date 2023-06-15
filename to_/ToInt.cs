using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.to_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ToIntX
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
		static public int ToInt(this bool x) {
			return x ? 1 : 0;
		}

		/// <summary>
		/// neg one for false; positive one for true, as is done in <see cref="ToInt(bool)"/>
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public int ToNegPosOne(this bool x) {
			return x ? 1 : -1;
		}


	}
}
