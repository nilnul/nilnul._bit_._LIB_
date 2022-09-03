using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr.duo.op.imply
{
	public class Apply: Call
	{
		public Apply(E e, E e1):base(nilnul.bit.duo.op.Le.Singleton, e,e1)
		{

		}
	}
}
