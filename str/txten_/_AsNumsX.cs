using nilnul.bit.str.each_;
using nilnul.bit.str.to_;
using nilnul.bit.to_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.txten_
{
	static public class _AsNumsX
	{
		static public string AsNums(in IEnumerable<bool> x) {
			return nilnul.obj.str._PhraseX.Phrase(
				x.ToNums()
			);
		}

	



	}
}
