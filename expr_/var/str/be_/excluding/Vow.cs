using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.bit.var.str.be_.excluding
{
	public class Vow
		: nilnul.obj.be.Vow<nilnul.bit.var.StrI1>
	{
		public Vow(nilnul.bit.VarI1 var) : base(new nilnul.bit.var.str.be_.Excluding(var))
		{
		}
	}
}
