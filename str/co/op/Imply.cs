using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.str.op
{
	public partial class Imply
	{
		static public bool _Eval_twoStrSameLen(bool[] row0, bool [] row1) {

			for (int i = 0; i < row0.Length; i++)
			{
				if ( bit.op.binary.NonImply.Eval( row0[i],row1[i]))
				{
					return false;
					
				}
			}
			return true;
		
		}


		static public bool _Eval_twoStrSameLen(ref bool[] row0, ref bool[] row1)
		{

			for (int i = 0; i < row0.Length; i++)
			{
				if (bit.op.binary.NonImply.Eval(row0[i], row1[i]))
				{
					return false;

				}
			}
			return true;

		}

	}
}
