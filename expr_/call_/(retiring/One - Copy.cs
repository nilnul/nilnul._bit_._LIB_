using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{
	[Obsolete()]
	public class One: nilnul.bit.expr_.call_.Nary
	{
		public One():base(true)
		{

		}


		static public One Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<One>.Instance;
			}
		}


	}
}
