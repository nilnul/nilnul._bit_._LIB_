using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nary_
{
	public class Nil_generi: nilnul.obj.expr_.typed_.generi_.call_.Nary<bool>
		,
		nilnul.bit.ExprI_generi
		,
		bit.expr_.ClosedI
	{
		public Nil_generi():base(false)
		{

		}


		static public Nil_generi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil_generi>.Instance;
			}
		}


	}
}
