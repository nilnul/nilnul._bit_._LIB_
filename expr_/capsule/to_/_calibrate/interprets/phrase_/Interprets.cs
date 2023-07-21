using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.state
{
	public class Interprets
	{
		 static public string ToTxt(IEnumerable<Interpret> s) {
			return nilnul.str.ToTxtX.ToTxt_byLoop(s , Environment.NewLine);
		}


		static public string ToTxt_sortVar(IEnumerable<Interpret> s)
		{
			return ToTxt(  s.OrderBy(x=>x,  nilnul.bit.var.set.state.interpret.Comparer.Lazy));
		}




	}
}
