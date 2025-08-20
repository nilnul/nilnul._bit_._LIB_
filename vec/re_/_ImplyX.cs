using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.vec.re_
{
	static public class _ImplyX
	{

		static public bool _Re_assumeEquisize(IEnumerable< bool> row0, IEnumerable< bool > _row1_sameLen) {
			/// note: "All" doesnot take index parameter;
			///

			for (int i = 0; i < row0.Count(); i++)
			{
				if (
					bit.op_.binary_.Gt.Singleton.op(
						row0.ElementAt(i)
						,
						_row1_sameLen.ElementAt(i)
					)
				)
				{
					return false;
				}
			}
			return true;
		
		}

		static public bool _Re_assumeEquisize(bool[] row0, bool [] _row1_sameLen) {

			for (int i = 0; i < row0.Length; i++)
			{
				if (bit.op_.binary_.Gt.Singleton.op( row0[i],_row1_sameLen[i]))
				{
					return false;
				}
			}
			return true;
		}


		static public bool _Re_assumeEquisize(ref bool[] row0, ref bool[] _row1_sameLen)
		{

			for (int i = 0; i < row0.Length; i++)
			{
				if (bit.op_.binary_.Gt.Singleton.op(row0[i], _row1_sameLen[i]))
				{
					return false;
				}
			}
			return true;
		}
	}
}
