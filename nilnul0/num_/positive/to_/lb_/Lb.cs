using nilnul.num_.positive.to_.lb_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive
{
	/// <summary>
	/// the index of the most significant bit;
	/// </summary>
	static public class _LbX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_positive"></param>
		/// <param name="strict">
		/// all other bits are nil;
		/// </param>
		/// <returns></returns>
		static public int _Lb_assumePositive(int _positive, out bool strict)
		{

			return _OfIntX._Lb_assumePositive(_positive,out strict);


		}
		static public int Lb(int _positive, out bool strict)
		{
			return _OfIntX.Lb(_positive, out strict);

		}
	}
}
