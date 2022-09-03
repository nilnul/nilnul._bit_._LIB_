using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.assignment.re_
{
	public class SameVar : nilnul.obj.ReI<Assignment>
	{
		public bool re(Assignment x, Assignment y)
		{
			return nilnul.obj.var.Eq1.Instance.Equals((nilnul.obj.VarI1) x.var,y.var);
 		}
	}
}
