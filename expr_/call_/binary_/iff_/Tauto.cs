using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_.iff_
{
	public class Tauto : iff.be_.tauto.vow.Ee
	{
		public Tauto(Iff_sys val) : base(val)
		{
		}
		

		public Tauto(ExprI_sys a, ExprI_sys b):this(new Iff_sys(a,b))
		{

		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
