using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.co
{
	static public class _SortieX
	{

		static public IEnumerable<(bool? former, bool? latter)> Seq() {
			var bits = bit0nul._SortieX.ARRAY;

			return nilnul.obj.str.strung.op_.binary_._CartesianX.Seq_byQuery(
					bits
					,
					bits

			);
		}

		static public readonly (bool? former, bool? latter)[] Array = Seq().ToArray();

		public const int COUNT = 9;
	}

}
