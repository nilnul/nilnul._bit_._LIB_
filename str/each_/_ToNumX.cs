using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;
using nilnul.bit.to_;

namespace nilnul.bit.str.each_
{
	/// <see cref="nilnul.bit.str.to.ToIntX"/>
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _ToNumX
	{

		static public IEnumerable<int> ToNums(this IEnumerable<bool> str) {

			return str.Select(x => x.ToNum());


		}



	}
}
