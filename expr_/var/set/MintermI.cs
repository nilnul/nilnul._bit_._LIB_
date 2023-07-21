using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set
{
	/// <summary>
	/// can be regarded as:
	///		dict
	///		subset of vars
	///		product of simple exprs(var or !var)
	/// </summary>
	///
	/// <see cref="nilnul.bit.var.sort.Minterm"/>
	/// alias:
	///		product
	public interface MintermI
	{
		var.Poll poll { get; }
	}
}
