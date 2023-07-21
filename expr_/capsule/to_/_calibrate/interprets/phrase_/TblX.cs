using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr._interpret
{
	static public class TblX
	{
		 static public string ToTxt(IEnumerable<Row> s) {
			return nilnul.str.ToTxtX.ToTxt_byLoop(s , Environment.NewLine);
		}


		static public string ToTxt_sortVar(IEnumerable<Row> s)
		{
			return ToTxt(  s.OrderBy(x=>x,  nilnul.bit.expr._interpret.row.Comparer.Lazy));
		}




	}
}
