using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.unary_.not.recur_
{
	public class Truthy :
		Recur
	{
		

		public Truthy():base(true)
		{
		}

	


		static public Truthy Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Truthy>.Instance;
			}
		}

	}
}
