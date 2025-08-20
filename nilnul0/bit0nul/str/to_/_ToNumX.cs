using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;
using nilnul.bit0nul.to_;

namespace nilnul.bit0nul.str.to_
{
	/// <see cref="nilnul.bit.str.to.ToIntX"/>
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _ToNumX
	{

		/// <summary>
		/// nul as 2; leftmost is the most insignificant;
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static public int ToNum(this IEnumerable<bool?> str) {
			var r = 0;
			//var count = str.Count();
			var weight = 1;

			foreach (var item in str)
			{
				r += item.ToNum() * weight;
				weight *= bit0nul._SortieX.COUNT;

			}

			return r;


		}



	}
}
