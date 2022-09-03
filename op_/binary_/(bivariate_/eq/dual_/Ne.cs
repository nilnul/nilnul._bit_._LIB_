using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// either or
	/// also known as
	///		"Ne",
	///			or "not equal".
	///		either or
	///			 exclusive or.
	///		modulo plus
	///		xor
	///		
	/// </summary>
	public class Ne : BinaryI, BinaryI1
		,
		IBivariate
		,
		binary_.CommutativeI
	{
		public bool op(bool par, bool par1)
		{
			return par ^ par1;
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// alternatives:
		///		^
		///		!=
		///		!==
		///		&lt;&gt;
		///		cicled plus
		///		
		/// </remarks>
		public const string TXT =
			"⊕"
			//"<>"
			//!=
			//!==
			;

		public override string ToString()
		{
			return TXT;
		}

		static public Ne Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Ne>.Instance;
			}
		}

	}
}
