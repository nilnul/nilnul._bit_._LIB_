using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.set.op
{
	public class Disjunct: nilnul.OpI<nilnul.bit.Set, bool>,OpI
		{
		static public Disjunct Singleton = SingletonByDefault<Disjunct>.Instance;

		public bool eval(Set arg){
				return nilnul.bit.str.summarize_._DisjunctX.Summarize(arg);

				throw new NotImplementedException();
		}
	}
}
