using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.str_
{
	public class Started : nilnul.obj.str_.Started<nilnul.bit.VarI1, nilnul.bit.var.StrI1>
		, nilnul.bit.var.StrI1
	{
		public Started(VarI1 head, bit.var.StrI1 tail) : base(head, tail)
		{
		}
	}
}
