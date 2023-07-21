using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterm
{
	/// <summary>
	/// given a set of vars, we have a collection of minterms such that each minterm'vars are those given vars. and the minterms are distinct in whether the multiplied  is var, or the negation of var
	/// </summary>
	public interface SetI:nilnul.obj.SetI1<MintermI>
	{

	}

	public class Set:
		nilnul.obj.Set<MintermI,minterm.Eq>
		,
		SetI
	{

	}
}
