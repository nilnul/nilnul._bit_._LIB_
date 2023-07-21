using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// not imply; A-B; not lessThan; not le
	/// </summary>
	/// <remarks>
	/// A and notB; A but B
	/// </remarks>
	/// alias:
	///		abjunction 
	///		
	public class Gt : BinaryI, BinaryI1
		,
		IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return !Imply.Singleton.op(par,par1);
			//throw new NotImplementedException();
		}
		public const string TXT = ">";
		public override string ToString()
		{
			return TXT;
		}


		static public Gt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Gt>.Instance;
			}
		}


	}
}
