using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_
{
	/// <summary>
	/// naryExpr is like proposition in that it has only one row (and zero cols for vars), the value of which is either true or false.
	/// </summary>
	public interface NaryI:CallI1
		,_nullary_.OpI1
	{

	}
}
