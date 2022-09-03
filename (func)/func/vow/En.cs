using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.vow
{
	public class En<TVow>
		: nilnul.vow.En<nilnul.bit.FuncI2, TVow>
		where TVow : nilnul.bit.func.VowI, new()
	{
		public En(FuncI2 val) : base(val)
		{
		}
	}
}
