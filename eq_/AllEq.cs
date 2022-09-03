using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.eq_
{
	/// <summary>
	/// this is pure theoretical and useless 
	/// </summary>
	public class AllEq
		:
		nilnul.bit.EqI
	{
		public bool Equals(bool x, bool y)
		{
			return true;
			//throw new NotImplementedException();
		}

		public int GetHashCode(bool obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public AllEq Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<AllEq>.Instance;
			}
		}

	}
}
