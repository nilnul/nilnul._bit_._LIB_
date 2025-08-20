using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.nulable.of_
{
	static public class _IntX
	{
		static public bool? Of(int x) {
			return x == 0 ? null : (x>0);
		}
	}
}
