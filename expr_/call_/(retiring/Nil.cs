using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{
	[Obsolete()]
	public class Nil_sys:
		nilnul.bit.expr_.call_.Nary_sys
	{
		public Nil_sys():base(false)
		{

		}


		static public Nil_sys Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil_sys>.Instance;
			}
		}


	}
}
