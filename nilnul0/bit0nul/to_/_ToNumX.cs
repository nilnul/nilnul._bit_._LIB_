using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.to_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ToNumX
	{
		
		static public int ToNum(this bool? x) {
			return x is null?2: ( x.Value ? 1 : 0 );

			return Array.IndexOf(bit0nul._SortieX.ARRAY, x);
		}

	


	}
}
