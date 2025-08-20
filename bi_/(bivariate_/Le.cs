using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_
{
	/// <summary>
	/// implication.  -> 
	/// </summary>
	/// <remarks>
	/// !x | y
	/// </remarks>
	/// alias:
	///		le
	///			less than or eq
	///		imply
	///		then
	///	vs:
	///		<see cref="nilnul.bit.expr_.tauto_.Inference"/> which returns void (including exception thrown), whileas this returns bit.
	///		
	public class Le : BinaryI, BinaryI1
		,
		IBivariate
	{
		public bool op(bool par, bool par1)
		{
			return !par || par1;
			//throw new NotImplementedException();
		}
		/// <summary>
		/// confusing with "->"
		/// </summary>
		/// \ means imply?
		/// 
		/// 
		public const string TXT = @"<=";
		public override string ToString()
		{
			return TXT;
		}

		static public Le Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Le>.Instance;
			}
		}

	}
}
