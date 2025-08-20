using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;

namespace nilnul.bit.str.to
{
	static public class ToIntX
	{
		static public int ToInt(this StrI str) {
			var r = 0;
			var count = str.Count();

			for (int i = count-1; i >=0; i--)
			{
				r <<= 1;

				r += str.ElementAt(i).ToInt();


			}
			return r;


		}

		static public int ToInt(this IEnumerable<bool> str) {
			return ToInt( new nilnul.bit.str.EnumerableAsStr(str));


		}


	}
}
