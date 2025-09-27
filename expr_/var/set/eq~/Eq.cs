using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	

	[Obsolete()]
	public class Eq:nilnul.ord.EqFroLe_leDefault<Set,Inside>
	{
		static public readonly Eq Instance = new Eq();


	}
}
