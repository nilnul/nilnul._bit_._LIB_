using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortie_.list.be_
{
	/*extern alias obj;*/
	public class Unary : /*obj::*/nilnul.obj.BeI1<nilnul.bit.var.sortie_.List>
	{
		public bool be(List d)
		{
			return d.vars.Count == 1;
			throw new NotImplementedException();
		}

		static public readonly Unary Singleton = nilnul.obj.SingletonByDefault<Unary>.Instance;

	}
}
