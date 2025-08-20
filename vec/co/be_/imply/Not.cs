using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.duo_.sameLen.be_.imply
{
	public class Not
	{
		static public bool _Eval_twoStrSameLen(IEnumerable< bool> row0, IEnumerable< bool> _row1_sameLen)
		{

			return _Eval_twoStrSameLen(ref row0,ref _row1_sameLen);

		}

		static public bool _Eval_twoStrSameLen(bool[] row0, bool[] _row1_sameLen)
		{

			return _Eval_twoStrSameLen(ref row0,ref _row1_sameLen);

		}

		static public bool _Eval_twoStrSameLen(ref IEnumerable< bool> row0, ref IEnumerable< bool> _row1_sameLen)
		{

			return !Imply._Eval_twoStrSameLen(row0, _row1_sameLen);

		}

		static public bool _Eval_twoStrSameLen(ref bool[] row0, ref bool[] _row1_sameLen)
		{
			return !Imply._Eval_twoStrSameLen(row0, _row1_sameLen);
		}
	}
}
