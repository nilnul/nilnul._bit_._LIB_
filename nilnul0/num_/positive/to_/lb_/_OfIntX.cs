using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.to_.lb_
{
	/// <summary>
	/// the index of the most significant bit;
	/// </summary>
	static public class _OfIntX
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

			var r = 0;      //2^0=1
			strict = true;

			while (true)
			{
				if ((_positive & 0x1) != 0)
				{
					if ((_positive >>= 1) > 0)
					{
						if (strict)
						{
							strict = false;
						}
						r++;
					}
					else
					{
						break;
					}

				}
				else
				{
					if ((_positive >>= 1) > 0)
					{

						r++;
					}
					else
					{
						break;
					}

				}

			}
			return r;


		}
		static public int Lb(int _positive, out bool strict)
		{
			nilnul.bit.vow_.True1.Vow(_positive > 0, $"{_positive} has to be positive for Lb operation.");

			return _Lb_assumePositive(_positive, out strict);




		}
	}
}
