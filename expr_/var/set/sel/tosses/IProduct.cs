using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var.set.sel
{
	/// <summary>
	/// can be regarded as:
	///		dict
	///		subset of vars
	///		product of simple exprs(var or !var)
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="var.set.sel"/>, this is the product, not sum of the items of the poll.
	/// </remarks>
	/// alias:
	///		在含有n个命题变项的简单合取式中，若每个命题变项和它的否定式不同时出现，而二者之一必出现且仅出现一次，且第i个命题变项或它的否定式出现在从左算起的第i位上（若命题变项无角标，就按字典顺序排列），称这样的简单合取式为极小项。 
	///
	/// <see cref="nilnul.bit.var.sort.Minterm"/>
	/// alias:
	///		product
	public interface IProduct
	{
	}

}
