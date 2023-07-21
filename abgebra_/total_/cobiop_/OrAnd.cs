using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra_.total_.cobiop_
{
	/// we need the plus
	///		: or , xor
	///	we need the multi:
	///		and, eq
	///	to be distributive:
	///		x & (y | z)
	///		x & (y ^ z)
	///
	/// as or is morgan for "and",
	/// so we finally settle with
	///		 or, and
	/// <summary>
	///  for the Or,
	///
	/// we cannot have inverse for every val.
	/// </summary>
	/// 
	/// morgan
	/// ,
	/// 0 as the plus unard
	/// 
	/// 1 as the and unard
	///
	///
	/// they are distributive.
	///
	/// for one to be ring, we only need the nonnil to have inverse.
	///
	/// 
	public interface IOrAnd
	{
	}
}
