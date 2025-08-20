using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.matrix
{
	static public class _OfX
	{
		/// 
		/// <summary>
		/// if it's 0, false; otherwise true.
		/// </summary>
		/// in align with other language;
		/// <remarks>
		///
		/// </remarks>
		/// <param name="nil0not"></param>
		/// <returns></returns>
		static public bool[,] BitMatrix(int[, ] nil0not) {

			int rows = nil0not.GetLength(0);
			int cols = nil0not.GetLength(1);
			var r = new bool[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					r[i, j] = (nil0not[i,j] != 0);
				}
			}
			return r;
		}
	}
}
