using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.to;

namespace nilnul.bit.stream
{
	static public class ToX
	{
		static public int ToInt(this StreamI str)
		{
			var r = 0;
			var i = 0;
			while (i++ < 8)
			{
				r += (str.next().ToInt() << i);
			}

			return r;


		}

		static public byte ToByte(this StreamI str)
		{
			byte r = 0;
			var i = 0;
			while (i++ < 8)
			{
				r += (byte)(str.next().ToByte() << i);
			}

			return r;


		}

		static public int ToInt(this IEnumerable<bool> str)
		{

			return ToInt(new nilnul.bit.stream.box.EnumerableAs(str) as StreamI);


		}

		static public byte ToByte(
			this IEnumerable<bool> seq
		)
		{

			return ToByte(new nilnul.bit.stream.box.EnumerableAs(seq) as StreamI);


		}


	}
}
