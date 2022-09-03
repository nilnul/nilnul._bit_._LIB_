using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo.be_
{
	/*extern alias obj;*/
	public class Imply : /*obj::*/nilnul.obj.BeI1<nilnul.bit.expr_.call_.Duo1>
	{
		public bool be(Duo1 d)
		{
			return nilnul.bit.combine.Eq.Singleton.Equals(nilnul.bit.combine_.Le.Singleton, d.op); 
			//throw new NotImplementedException();
		}


		static public readonly Imply Singleton = nilnul.obj.SingletonByDefault<Imply>.Instance;

	}
}
