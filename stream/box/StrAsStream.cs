using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream.box
{
	public class StrAsStream
		:
		nilnul.stream.box.EnumerableAs_default<bool>,
		
		StreamI
	{
		public StrAsStream(nilnul.bit.StrI str):base(str)
		{

		}

		public StrAsStream(BitArray bitArray):this(
			new nilnul.bit.str.promo.BitArrayAsStr(bitArray)
		)
		{

		}

	}
}
