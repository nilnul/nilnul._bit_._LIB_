using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.str_
{
	public class Enumable : nilnul.obj.str_.Enumable<nilnul.bit.VarI1>
		,
		nilnul.bit.var.StrI1
	{
		public Enumable(IEnumerable<VarI1> boxed) : base(boxed)
		{
		}
	}
}
