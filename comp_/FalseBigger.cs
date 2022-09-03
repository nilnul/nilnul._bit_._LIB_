using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.comp_
{
	public class FalseBigger : IComparer<bool>
	{
		public int Compare(bool x, bool y)
		{
			if (x)
			{
				if (y)
				{
					return 0;
				}
				return -1;
			}
			if (y)
			{
				return 1;
			}
			return 0;
		}
		//throw new NotImplementedException();

		static private Lazy<FalseBigger> _Lazy = new Lazy<FalseBigger>();
		static public FalseBigger Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


	}
}
