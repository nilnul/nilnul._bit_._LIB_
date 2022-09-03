using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.be_
{
	static public class _CommutableX
	{
		static public bool Be(BinaryI1 op)
		{
			var x = new nilnul.bit.Var2();
			var y = new nilnul.bit.Var2();

			return nilnul.bit.expr_.plain.be_.Tauto.Singleton.be(
				nilnul.bit.expr_.plain_.call_.Binary.CreateEq(
					new nilnul.bit.expr_.plain_.call_.Binary(
						op
						,
						x
						,
						y

					)
					,
					new nilnul.bit.expr_.plain_.call_.Binary(
						op,
						y
						,
						x
					)
				)
			);
		}
	}

	public interface CommutableI : BeI
	{
	}
	public class Commutable : CommutableI
	{
		public bool be(BinaryI1 obj)
		{
			return _CommutableX.Be(obj);
			//throw new NotImplementedException();
		}

		static public Commutable Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Commutable>.Instance;
			}
		}

	}
}
