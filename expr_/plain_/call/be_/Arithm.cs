using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_.call.be_
{
	public class Arithm : BeI
	{
		public bool be(CallI obj)
		{
			return obj.vars.Count == 0;
			//throw new NotImplementedException();
		}

		static public Arithm Singleton
		{
			get
			{
				return nilnul.Singleton1<Arithm>.Instance;
			}
		}

	}
}
