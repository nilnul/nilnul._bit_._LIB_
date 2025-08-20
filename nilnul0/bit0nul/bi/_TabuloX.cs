using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi
{
	static public class _TabuloX
	{
		/// <summary>
		/// outcome column of the tableaux for the operator;
		/// the input columns (for binary op, two) are usually put in front of the outcome column;
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		static public IEnumerable<bool?> OutcomeAsSeq(bit0nul.BiI op) {
			return bit0nul.co._SortieX.Array.Select(
				c=>op.op(c.Item1,c.Item2)
			);
		}




	}
}
