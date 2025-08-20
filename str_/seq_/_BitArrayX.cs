using System.Collections;
using System.Collections.Generic;

namespace nilnul.bit.str_.seq_
{
	static public class _BitArrayX
	{

		static public  IEnumerator<bool> AsEnumerator(this BitArray _val)
		{
			for (int i = 0; i < _val.Length; i++)
			{
				yield return _val[i];
			}
		}
		static public  IEnumerable<bool> AsSeq(this BitArray _val)
		{
			for (int i = 0; i < _val.Length; i++)
			{
				yield return _val[i];
			}
		}


	}
}
