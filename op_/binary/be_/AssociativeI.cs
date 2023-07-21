using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.be_
{
	static public class _AssociativeX
	{
		static public bool Be(BinaryI1 op) {
			var x = new nilnul.bit.Var2();
			var y = new nilnul.bit.Var2();
			var z = new nilnul.bit.Var2();

			return nilnul.bit.expr_.plain.be_.Tauto.Singleton.be(

				nilnul.bit.expr_.plain_.call_.Binary.CreateEq(
					new nilnul.bit.expr_.plain_.call_.Binary(
						op,
						x
						,
						new nilnul.bit.expr_.plain_.call_.Binary(
							op,
							y
							,
							z
						)
					)
					,
					new nilnul.bit.expr_.plain_.call_.Binary(
						op,
						new nilnul.bit.expr_.plain_.call_.Binary(
							op,
							x
							,
							y
						)
						,
						z
					)

				)

				
			);
		}

		public static bool Be(BinaryI<bool> op)
		{
			return Be(new nilnul.bit.op_.Binary(op.op));
			
		}
	}

	public interface AssociativeI:BeI
	{
	}
	public class Associative :
		AssociativeI
		,
		nilnul.bit.op_.binary.Be_ofGeneriI
	{
		public bool be(BinaryI1 obj)
		{
			return _AssociativeX.Be(obj);
			//throw new NotImplementedException();
		}

		public bool be(BinaryI<bool> obj)
		{

			return _AssociativeX.Be(obj);

			//throw new NotImplementedException();
		}

		static public Associative Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Associative>.Instance;
			}
		}

	}
}
