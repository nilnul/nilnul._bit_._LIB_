using nilnul.bit.str_.seq_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.where_.one._count_
{
	/// <summary>
	/// populated bits count;
	/// </summary>
	static public class _ByX
	{
		static public int ByShift(byte x)
		{
			int c = 0;
			while (x > 0)
			{
				c += x & 1;
				x >>= 1;
			}
			return c;
		}

		//static public int ByBitOperations(byte x) {
		//	return BitOperations
		//}



		///techiedelight.com/brian-kernighans-algorithm-count-set-bits-integer/
		/// <summary>
		/// Function to count the total number of set bits in `n`
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int ByBrianKernighan(int n)
		{

			/*
1st iteration of the loop: n = 52
 
00110100    &               (n)
00110011                    (n-1)
~~~~~~~~
00110000

2nd iteration:

00110000    &               (n)
00101111                    (n-1)
~~~~~~~~
00100000

3rd operation
00100000    &               (n)
00011111                    (n-1)
~~~~~~~~
00000000                    (n = 0)

			 */


			// `count` stores the total bits set in `n`
			int count = 0;

			while (n != 0)
			{
				n = n & (n - 1);    // clear the least significant bit set
				count++;
			}

			return count;
		}



	}
}
