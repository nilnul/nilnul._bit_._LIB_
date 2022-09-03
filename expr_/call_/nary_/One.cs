using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{
	public class One2: nilnul.obj.expr_.typed_.generi_.call_.Nary<bool>
		,
		nilnul.bit.expr_.ClosedI
	{
		public One2():base(true)
		{

		}


		static public One2 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<One2>.Instance;
			}
		}


	}
}
