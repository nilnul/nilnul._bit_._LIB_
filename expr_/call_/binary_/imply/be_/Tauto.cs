using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.duo_.imply.be_
{
	/// <summary>
	/// there are two methods to determine whether the imply is tauto:
	/// 1) truthtable
	/// 2) proof
	/// </summary>
	public class Tauto:BeI
	{

		static public bool Eval(bit.ExprI1 A, bit.ExprI1 B) {
			return nilnul.bit.expr.be_.Tauto.Eval(
				nilnul.bit.expr_.call_.Duo.CreateImply(A,B)
			);
		}
		static public bool Eval(Imply B) {
			return nilnul.bit.expr.be_.Tauto.Eval(
				B.vowed
			);
		}

		public bool be(Imply obj)
		{
			return Eval(obj);
			throw new NotImplementedException();
		}


		static public readonly Tauto Singleton = nilnul.obj.SingletonByDefault<Tauto>.Instance;

	}
}
