using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	/// <summary>
	/// tup is different from str in that:
	///		tup is nilnul.(givenLenth).str
	///	when we use tup, it's implied that the length is given.
	///		eg:
	///			tups are of strs of the same length
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		as we use bits to denote bit.Str, we have a long-form alternative to denote similar things and this long-form is "nilnul.bit.Tup"
	/// alias:
	///		tup
	///			tuple is the basis to form an extended typ
	///			tuple
	///		vect
	///			vector
	/// </remarks>
	interface ITup:nilnul.bits_.ILengthed
	{
	}
}
