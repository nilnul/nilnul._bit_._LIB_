using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// iif; eq;equiv;iff;
	/// </summary>
	/// alias:
	///		xnor
	///		biconditional
	///		eq
	///		equiv
	///		iff
	///		equal
	///		iif
	///		biimplication
	///		bientaiment
	///		material biconditional
	public class Eq : BinaryI, BinaryI1
		,
		bit.op_.binary_.IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return par == par1;
			//throw new NotImplementedException();
		}

		public const string TXT =
			"~"
			//"=="
			//"="
			;
		public override string ToString()
		{
			return TXT;
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

	}
}
