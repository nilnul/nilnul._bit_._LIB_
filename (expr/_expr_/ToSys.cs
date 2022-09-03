using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr_
{
	/// <summary>
	/// convert to system.linq.Expression
	/// </summary>
	public interface ToSysI
	{
		System.Linq.Expressions.Expression toSys();
	}
}
