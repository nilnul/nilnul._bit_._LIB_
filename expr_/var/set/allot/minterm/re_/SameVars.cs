using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterm.re_
{
	public class SameVars : ReI
	{
		public bool re(MintermI a, MintermI b)
		{
			return nilnul.bit.var.set.Eq1.Singleton.Equals(a.poll.Keys,b.poll.Keys);
			throw new NotImplementedException();
		}

		static public SameVars Singleton
		{
			get
			{
				return nilnul._obj.Singleton<SameVars>.Instance;
			}
		}

	}
}
