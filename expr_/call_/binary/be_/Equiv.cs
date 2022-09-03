using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo.be_
{
	/*extern alias obj;*/
	public class Equiv : /*obj::*/nilnul.obj.BeI1<nilnul.bit.expr_.call_.Duo1>
	{
		public bool be(Duo1 d)
		{
			return nilnul.bit.combine.Eq.Singleton.Equals(nilnul.bit.combine_.Eq.Singleton, d.op); 
			//throw new NotImplementedException();
		}


		static public readonly Equiv Singleton = nilnul.obj.SingletonByDefault<Equiv>.Instance;

	}
}
