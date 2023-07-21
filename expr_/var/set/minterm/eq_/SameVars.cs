using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterm.eq_
{
	public class SameVars :
		nilnul.obj._eq_.HashCodeA<MintermI>
		
	{
		public override bool Equals(MintermI x, MintermI y)
		{
			return nilnul.bit.var.set.Eq1.Singleton.Equals(x.poll.Keys, y.poll.Keys);

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
