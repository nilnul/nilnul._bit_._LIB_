using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.re_.poset_
{
	static public class _LinearX
	{
		static public IEnumerable<bool> LinearByResultAsSeq(op_.BinaryI1 op) {
			return bit.co.Sortie.All.ee.Select(
				c=>op.op(c.Item1,c.Item2)
			);

		}


		static public int LinearByResult(op_.BinaryI1 op) {
			return bit.str.op_.to_._AsRadixX.AsRadix(

				LinearByResultAsSeq(op)
			 );

		}


	}
}
