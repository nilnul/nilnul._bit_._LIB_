using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.nary.dual_
{
	public class OpDefault<TOp>
		: Dual<TOp>
		where TOp : op_.NaryI, new()
	{
		public OpDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance)
		{
		}


		static public OpDefault<TOp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OpDefault<TOp>>.Instance;
			}
		}

	}
}
