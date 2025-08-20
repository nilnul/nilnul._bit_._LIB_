using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.promo
{

	[Obsolete(nameof(str_.seq_._BitArrayX))]
	public class BitArrayAsStr 
		: 
		 StrA
	{

		private BitArray _val;

		public BitArray val
		{
			get { return _val; }
			set { _val = value; }
		}

		public BitArrayAsStr(BitArray val)
		{
			_val = val;
		}

		public override IEnumerator<bool> GetEnumerator()
		{
			for (int i = 0; i < _val.Length; i++)
			{
				yield return _val[i];
			}

			//throw new NotImplementedException();
		}
	}
}
