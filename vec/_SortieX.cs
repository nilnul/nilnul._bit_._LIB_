using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vec
{
    static public class _SortieX
    {
		static public bool[,] _AsMatrix_0arity(int arity) {
			var rows = 1 >>arity; /// 2^arity

			var r = new bool[
				rows
				,
				arity
			];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < arity; j++)
				{
					r[i, j] = (
						(i >> j)	/// move the bits[j] to the rightmost
						& 1		/// ignore other bits
					) == 1;
				}
			}
			return r;

		}

	}
}
