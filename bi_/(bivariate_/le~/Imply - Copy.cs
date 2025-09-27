using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		le
	///			less than or eq
	/// </remarks>
	/// 
	///
	[Obsolete(nameof(op_.binary_.Le))]
	public class Imply : BinaryI, BinaryI1
	{
		public bool op(bool par, bool par1)
		{
			return !par || par1;
			//throw new NotImplementedException();
		}
		public const string TXT = @"\";
		public override string ToString()
		{
			return TXT;
		}

		static public Imply Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Imply>.Instance;
			}
		}

	}
}
