using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// either or
	/// also known as "Ne", or "not equal". either or; exclusive or.
	/// </summary>
	///
	[Obsolete()]
	public class Xor : BinaryI, BinaryI1
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
		/// </remarks>
		public const string TXT = "⊕";

		public override string ToString()
		{
			return TXT;
		}

		static public Xor Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Xor>.Instance;
			}
		}

	}
}
