using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interprets.be_
{
	public class SameVars_Diff : BeI
	{
		public bool be(IEnumerable<Interpretation> obj)
		{
			return SameVars.Singleton.be(obj) && Diff.Singleton.be(obj);

			//throw new NotImplementedException();
		}


		static public readonly SameVars_Diff Singleton = SingletonByDefault<SameVars_Diff>.Instance;

	}
}
