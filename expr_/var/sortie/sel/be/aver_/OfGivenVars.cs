using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.bit.var.sortedSet.state.be.aver_
{
	public class OfGivenVars
		: nilnul.obj.be.Aver<nilnul.bit.var.sortedSet.State>
	{
		


		public OfGivenVars(nilnul.bit.var.SortedSet vars):base(
			new nilnul.bit.var.sortedSet.state.be_.OfGivenVars(vars)	
		)
		{
		}
		
	}
}
