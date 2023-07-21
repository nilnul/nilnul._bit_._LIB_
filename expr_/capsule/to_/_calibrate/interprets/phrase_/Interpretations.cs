using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	public class Interpretations
	{
		 static public string ToTxt(IEnumerable<Interpretation> s) {
			return nilnul.str.ToTxtX.ToTxt_byLoop(s , Environment.NewLine);
		}
		 static public string ToTxt_sortVar(IEnumerable<Interpretation> s) {
			return nilnul.str.ToTxtX.ToTxt_byLoop(s.Select(x=>x.toTxt_sortVar()) , Environment.NewLine);
		}




	}
}
