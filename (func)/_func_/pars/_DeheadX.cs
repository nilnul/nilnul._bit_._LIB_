using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._func_.pars
{
	static public class _DeheadX
	{
		static public nilnul.bit.var.Sortie1 Dehead(nilnul.bit.var.Sortie1 sortie) {
			if (sortie.en.Any())
			{
				return nilnul.bit.var.sortie_.sown._DeheadX._Dehead(sortie);
			}
			return sortie;
		}
	}
}
