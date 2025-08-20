using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.rw_.ensure_
{
	/// <summary>
	/// </summary>
	/// alias:patch
	/// <seealso cref="bi_.ge"/>
	static public class _GeX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="original"></param>
		/// <param name="changed"></param>
		static public void EnsureGe(ref bool original, in bool changed)
		{
			/// 00 : 0
			/// 01: 1
			/// 10: 1
			/// 11: 1
			///
			/// 00: no action
			/// 01: set1
			/// 10: noaction
			/// 11: noaction
			/// 
			/// 
			/// 
			//if (
			///	!original&&changed
			///	 <see cref="bit.op_.binary_.Lt"/>
			//) {

			///	original = true;	/// <see cref="bi_._GeX"/>
			//}

			if ( changed)
			{
				ensure_._OneX.EnsureOne(ref original);
			}
		}
	}
}