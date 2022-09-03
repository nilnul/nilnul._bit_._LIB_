using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.to
{
	static public class ToByteX
	{
		static public byte ToByte(this bool x) {
			return x ? (byte)1 : (byte)0;
		}
	}
}
