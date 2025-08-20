using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.set.op
{
	public class Conjunct : nilnul.OpI<nilnul.bit.Set, bool>,OpI
	{
		static public Conjunct Singleton = SingletonByDefault<Conjunct>.Instance;
		public bool eval(Set arg)
		{
			return nilnul.bit.str.op.Conjunct.Eval(arg);
			throw new NotImplementedException();
		}
	}
}
