using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow;
using nilnul.obj_.xpn_;

namespace nilnul.bit.vow_
{
	public class True1<TXpn> :
		nilnul.obj.VowA1<bool, TXpn>
		,
		VowI
		//,		nilnul.bit.VowI
		where TXpn : Exception
	{
		public True1(TXpn xpn) : base(xpn)
		{
		}

		public override void vow(bool obj)
		{
			if (!obj)
			{
				throw this.boxed;
			}
		//	throw new NotImplementedException();
		}


	}

}
