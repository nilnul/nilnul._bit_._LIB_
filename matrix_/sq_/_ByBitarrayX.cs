using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.matrix_.sq_
{
	/// https://stackoverflow.com/questions/23717880/c-sharp-multidimensional-bitarray
	///
	///
	/// <summary>
	/// </summary>
	/// 
	static public  class _ByBitarrayX
	{


		/// <summary>
		/// get the row of the matrix;
		/// </summary>
		/// <param name="_sqMatrix">matrix assumed square</param>
		/// <param name="row">row index assumed valid;</param>
		/// <param name="widthCached">derivable from matrix that is square;</param>
		/// <returns></returns>
		static public IEnumerable<bool> _Row_assumesValid(
			BitArray _sqMatrix
			,
			int row
			,
			int widthCached // derivable
		) {

			var basic = row * widthCached;
		
			for (int col = 0; col < widthCached; col++)
			{
				yield return _sqMatrix[basic + col];
			}
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r">squre </param>
		/// <param name="col">valid col index</param>
		/// <param name="widthCached">cached width of matrix; this value can be derived from square matrix;</param>
		/// <returns></returns>
		static public IEnumerable<bool> _Col_assumesValid(
			BitArray r
			,
			int col
			,
			int widthCached // derivable
		) {
	
			for (int row = 0; row < widthCached; row++)
			{
				yield return r[row*widthCached + col];
			}
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// each parameter assumes valid value;
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <param name="r">square matrix;</param>
		/// <param name="row">valid</param>
		/// <param name="col">valid</param>
		/// <param name="widthCached">cached width of the matrix; this value is derivable from <paramref name="r"/></param>
		/// <returns></returns>

		static public bool _Cel_assumesValid(
			BitArray r
			,
			int row
			,
			int col
			,
			int widthCached // derivable
	
		) {
			return r[row*widthCached+col];
	
		
		}



	}
}
