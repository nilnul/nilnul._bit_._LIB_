using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.str.duo_.sameLen.be_
{

	[Obsolete(nameof(nilnul.bit.vec.re_._ImplyX))]
	public class Imply
	{

		static public bool _Eval_twoStrSameLen(IEnumerable< bool> row0, IEnumerable< bool > _row1_sameLen) {
			for (int i = 0; i < row0.Count(); i++)
			{
				if ( bit.op.binary.NonImply.Eval( row0.ElementAt(i),_row1_sameLen.ElementAt(i)))
				{
					return false;
				}
			}
			return true;
		
		}

		static public bool _Eval_twoStrSameLen(bool[] row0, bool [] _row1_sameLen) {

			for (int i = 0; i < row0.Length; i++)
			{
				if ( bit.op.binary.NonImply.Eval( row0[i],_row1_sameLen[i]))
				{
					return false;
				}
			}
			return true;
		}


		static public bool _Eval_twoStrSameLen(ref bool[] row0, ref bool[] _row1_sameLen)
		{
			for (int i = 0; i < row0.Length; i++)
			{
				if (bit.op.binary.NonImply.Eval(row0[i], _row1_sameLen[i]))
				{
					return false;
				}
			}
			return true;
		}
	}
}
