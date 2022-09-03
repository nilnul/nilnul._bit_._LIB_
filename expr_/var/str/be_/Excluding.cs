using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.bit.var.str.be_
{
	public class Excluding :

		nilnul.obj.be.Anto<nilnul.bit.var.StrI1>
		,
		nilnul.bit.var.str.BeI
	{
		public Excluding(nilnul.bit.VarI1 var) : base(new nilnul.bit.var.str.be_.Contain(var))
		{
		}
	}
}
