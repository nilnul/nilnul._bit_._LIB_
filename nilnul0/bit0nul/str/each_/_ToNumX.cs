using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;
using nilnul.bit0nul.to_;

namespace nilnul.bit0nul.str.each_
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
		static public IEnumerable<int> ToNums(this IEnumerable<bool?> str) {
			return str.Select(x => x.ToNum());


		}



	}
}
