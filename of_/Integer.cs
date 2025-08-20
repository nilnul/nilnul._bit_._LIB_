using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.of_
{
	static public class _IntegerX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool IsNonnil(this in int x) {
			return x != 0;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// can only be 0 or 1; otherwise, exception;
		/// </param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool IsNonnil_vowBit(this in int x)
		{
			return x switch
			{
				0 => false
				,
				1 => true
				,
				_ => throw new ArgumentOutOfRangeException(
					$"only 0 and 1 can be converted to bool; {x} is not 0 nor 1."
				)
			};
		}


	}
}
