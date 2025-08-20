using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.rw_.ensure_
{
	/// <summary>
	/// the original might be dirty or not.
	/// Touch it, and it will become dirty. Note touch a content twice, we might restore the content to its original state.
	/// Once it gets dirty, it cannot be clean again.
	/// </summary>
	static public class _OneX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="original"></param>
		static public void EnsureOne(ref bool original)
		{
			

			//original = true;
			// Reads and writes of the following data types are atomic: bool, char, byte, sbyte, short, ushort, uint, int, float, and reference types.as found in C# Language Spec.



			#region  is this better than directly assignment. directly assignment is atomic. the above is not and may involve racing.
			if (!original)
			{
				/// if original <![CDATA[ < ]]> 1
				 original =  true;
			}
			#endregion
		}
		
	}
}