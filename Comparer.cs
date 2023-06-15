using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	/// <summary>
	/// false is smaller than true;
	///  bit starts with false and then false->true;, 
	/// </summary>
	/// <remarks>
	///   bit is a subset of num;and num starts with 0, where 0 -> 1; 
	/// </remarks>
	/// alias:
	///		sign
	///			:false is -1, true is 1 when acting as multiplier;
	public class Comparer : IComparer<bool>
	{
		public int Compare(bool x, bool y)
		{
			if (x)
			{
				if (y)
				{
					return 0;
				}
				return 1;
			}
			if (y)
			{
				return -1;
			}
			return 0;
		}
		//throw new NotImplementedException();

		static private Lazy<Comparer> _Lazy = new Lazy<Comparer>();
		static public Comparer Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


	}
}
