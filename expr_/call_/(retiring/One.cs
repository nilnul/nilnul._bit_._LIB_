using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{

	[Obsolete()]
	public class One1: nilnul.bit.expr_.call_.Nary_sys
	{
		public One1():base(true)
		{

		}


		static public One1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<One1>.Instance;
			}
		}


	}
}
