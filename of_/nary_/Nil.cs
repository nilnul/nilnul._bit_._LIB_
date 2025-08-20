using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.nary_
{
	public class Nil :
		NaryI
	{
		public bool op()
		{
			return false;
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return "0";
		}

		static public Nil Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Nil>.Instance;
			}
		}

	}
}
