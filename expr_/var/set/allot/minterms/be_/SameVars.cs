using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterms.be_
{
	public class SameVars
		: 
		nilnul.obj.BeI1<IEnumerable<MintermI>>
	{
		public bool be(IEnumerable<MintermI> obj)
		{
			return nilnul.objs_.enumable.be_.EquivSub<MintermI, minterm.eq_.SameVars>.Singleton.be(obj);
			//throw new NotImplementedException();
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
