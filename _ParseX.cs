using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	static public class _ParseX
	{
		public const string TRUE = "true";
		public const string FALSE = "false";
		static public bool Exe(string x) {
			if (x==TRUE)
			{
				return true;
			}
			if (x==FALSE)
			{
				return false;
			}
			throw new ArgumentOutOfRangeException($"{x} is not in ({FALSE},{TRUE})");
		}
	}
}
