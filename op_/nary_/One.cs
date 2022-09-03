using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.nary_
{
	public class One : NaryI
	{
		public bool op()
		{
			return true;
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return "1";
		}

		static public One Singleton
		{
			get
			{
				return nilnul._obj.Singleton<One>.Instance;
			}
		}

	}
}
