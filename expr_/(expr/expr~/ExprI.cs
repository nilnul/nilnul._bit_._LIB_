using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;

namespace nilnul.bit
{
	[Obsolete()]
	public interface ExprI
		:nilnul.ExprI1<bool>	//empty
		,nilnul.obj.ExprI3<bool>
	{

	}




}
