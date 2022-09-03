using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.duo.vow
{
	public class En<TVow> :
		nilnul.vow.En<nilnul.bit.expr_.plain.Duo, TVow>
		where TVow : VowI, new()
	{
		public En(Duo val) : base(val)
		{
		}
	}
}
