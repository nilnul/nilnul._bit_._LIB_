using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.str.be_.excluding.vow
{
	public class Ed
		: nilnul.obj.vow.Ed<nilnul.bit.var.StrI1>
	{
		public Ed(nilnul.bit.VarI1 var, nilnul.bit.var.StrI1 str) : base(str,new nilnul.bit.var.str.be_.excluding.Vow(var))
		{
		}
	}
}
