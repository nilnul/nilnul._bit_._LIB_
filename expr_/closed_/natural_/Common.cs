using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.closed_.natural_
{
	/// <summary>
	/// use only common operators (see <see cref="nameof(nilnul.bit.op_.ICommon)"/>)
	/// </summary>
	/// <remarks>
	///	nomenclature:
	///		each expr_.Closed can be converted into Common directly, by changing each op into common op using equivalent substitution..
	/// </remarks>
	public interface ICommon:INatural
	{
	}
}
