using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interprets.be_
{
	/*extern alias obj;*/
	public class SameVars : 
		nilnul.objs.be_.Equiv<Interpretation>
		//,
		///*obj::*/nilnul.obj.BeI1<IEnumerable<Interpretation>>
	{
		public SameVars( ) : base(interpret.eq_.SameVars.Lazy)
		{
		}

		static public readonly SameVars Singleton = SingletonByDefault<SameVars>.Instance;

		public class En : nilnul.obj.be.En_beDefaultable<IEnumerable<Interpretation>, SameVars>
		{
			public En(IEnumerable<Interpretation> val) : base(val)
			{
			}

			static public bit.var.Set _getVars_assumeSameVars(IEnumerable<Interpretation> interprets) {

				if (interprets.Any())
				{
					return interprets.First().assignment.vars;
				}
				return new nilnul.bit.var.Set();
			}
		}

	}
}
