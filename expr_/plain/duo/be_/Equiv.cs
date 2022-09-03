using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.duo.be_
{
	public class Equiv : BeI
	{
		public bool be(Duo obj)
		{
			return eq_.Equiv.Singleton.Equals(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}

		static public Equiv Singleton
		{
			get
			{
				return nilnul.Singleton1<Equiv>.Instance;
			}
		}

	}
}
