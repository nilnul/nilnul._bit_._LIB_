using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be_.tauto.vow
{
	/*extern alias obj;*/


	public class Ed : nilnul.obj.be.vow.Ed_beDefaultable<ExprI1, Tauto>
	{
		public Ed(ExprI1 expr) : base(expr)
		{

		}

		public override string ToString()
		{
			return $"=>" + vowed.ToString();
		}
	}


}
