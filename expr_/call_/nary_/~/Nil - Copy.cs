using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{
	public class Nil: nilnul.bit.expr_.call_.Nary
	{
		public Nil():base(false)
		{

		}


		static public Nil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil>.Instance;
			}
		}


	}
}
