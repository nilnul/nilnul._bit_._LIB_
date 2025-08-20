using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream.box
{
	public class EnumerableAs
		:
		nilnul.stream.box.EnumerableAs_default<bool>,
		
		StreamI
	{
		public EnumerableAs(nilnul.bit.StrI str):base(str)
		{

		}

		public EnumerableAs(BitArray bitArray):this(
			new nilnul.bit.str.promo.BitArrayAsStr(bitArray)
		)
		{

		}

		public EnumerableAs(IEnumerable<bool> x):base(x)
		{

		}

	}
}
