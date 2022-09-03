using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._func_.pars
{
	static public class _PrependX
	{
		static public nilnul.bit.var.Sortie1 Prepend(nilnul.bit.var.Sortie1 sortie, nilnul.bit.VarI1 _head) {
			nilnul.obj.vow_.False.Vow(sortie.contain(_head));

			return new var.Sortie1(
				nilnul.str_.seq.convert_._PrependX.Seq(
					sortie.en
					, _head
				)
			);
		}
	}
}
