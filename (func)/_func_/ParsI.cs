using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._func_
{
	/// <summary>
	/// x => y => z=>f(x,y,z)   is equiv to (x,y,z) => f(x,y,z)
	/// such that for ((x,y,z) => f(x,y,z))  (w,v),  w will substitie x, not z
	/// 
	/// </summary>
	public interface ParsI
	{
		/// <summary>
		/// if the vars.count ==0, then we can imagine there is a special var of void, which is never instantiated.
		/// </summary>
		nilnul.bit.var.Sortie1 pars { get; }
	}
}
