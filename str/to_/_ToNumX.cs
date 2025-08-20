using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;
using nilnul.bit.to_;

namespace nilnul.bit.str.to_
{
	static public class _ToNumX
	{
		static public int ToNum(this IEnumerable<bool> str)
		{
			var r = 0;
			//var count = str.Count();
			var weight = 1;

			foreach (var item in str)
			{
				r += item.ToNum() * weight;
				//weight *= bit.Sortie.COUNT;
				weight <<=1;


			}

			return r;


		}



	}
}
