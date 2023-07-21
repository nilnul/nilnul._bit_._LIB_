using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.stati._stati
{
	public interface SubstituteI
	{
		bit.expr.stati.StatiI substitute(
			bit.var.stati.Stati var,
			bit.expr.stati.StatiI expr	
		);
	}
}
