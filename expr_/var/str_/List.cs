using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.str_
{
	public class ListEnumerator:
		nilnul.obj.str_.ListEnumerator<nilnul.bit.VarI1>
		,nilnul.bit.var.StrI1
	{
		public ListEnumerator(List<VarI1> list) : base(list)
		{

		}
	}
}
