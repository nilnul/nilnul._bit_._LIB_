using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._func_
{
	public interface VarsI1
	{
		/// <summary>
		/// if the vars.count ==0, then we can imagine there is a special var of void, which is never instantiated.
		/// </summary>
		nilnul.bit.var.sortie_.List vars { get; }
	}
}
