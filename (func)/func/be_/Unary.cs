using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.be_
{
	/// <summary>
	/// the expression of the funcis tauto.
	/// </summary>
	public class Unary : nilnul.bit.func.BeI
	{
		public bool be(FuncI1 obj)
		{
			return nilnul.bit.var.sortie_.list.be_.Unary.Singleton.be(obj.vars);
			throw new NotImplementedException();
		}

		static public readonly Unary Singleton = nilnul.obj.SingletonByDefault<Unary>.Instance;

	}
}
