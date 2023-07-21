using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr_
{
	public interface BlankI:
		nilnul.obj._expr_.BlankI<bool>
		,
		nilnul.obj._expr_.blank_.RetI<bool>
	{
	}
}
