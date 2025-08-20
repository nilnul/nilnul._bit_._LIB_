using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit_
{
	/// <summary>
	/// why false, not true, is taken as the default value?
	///	ans:
	///		eg: let's denote one student as the contact person of a group in excel. the column "contact" would be left unfilled if the person is not that contact, and that value in the cell shall be defaulted as false;
	/// </summary>
	static public class _DefaultedX
	{
		public const bool DEFAULT = false;
	}
}
