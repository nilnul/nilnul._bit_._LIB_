using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo.be_.equiv.vow
{
	/// <summary>
	/// </summary>
	public class Ed
		: nilnul.obj.vow.Ed<Duo1, Vow>
	{
		public Ed(Duo1 val) : base(val)
		{
		}

		public Ed(nilnul.bit.ExprI1 a, nilnul.bit.ExprI1 b):this( Duo1.CreateEq(a,b))
		{

		}
	}
}
