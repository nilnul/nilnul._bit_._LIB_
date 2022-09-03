using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr
{
	[Obsolete(nameof(_expr_.SubstituteI))]
	public interface SubstituteI
	{
		bit.ExprI_membered substitute(
			bit.VarI1 var,
			bit.ExprI_membered expr	
		);
	}
}
