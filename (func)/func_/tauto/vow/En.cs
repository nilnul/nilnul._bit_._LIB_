using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func_.tauto.vow
{
	public class En<TVow> : nilnul.vow.En<nilnul.bit.func_.TautoI, TVow>
		where TVow : VowI, new()
	{
		public En(TautoI val) : base(val)
		{
		}
	}
}
