using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.unary_.not.recur_
{
	public class Falsy :
		Recur
	{
		

		public Falsy():base(false)
		{
		}

	


		static public Falsy Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Falsy>.Instance;
			}
		}

	}
}
