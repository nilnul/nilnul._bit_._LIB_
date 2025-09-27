using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.nulary_
{
	public class One
	{
		static private Nulary _Singleton = Nulary.CreateOne();

		static public Nulary Singleton
		{
			get
			{
				return _Singleton;
			}
		}

	}
}
