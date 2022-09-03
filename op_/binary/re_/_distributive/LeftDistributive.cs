using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.re_._distributive
{
	/// <summary>
	/// 
	/// </summary>
	public class LeftDistributive
				: nilnul.obj.op_.binary.re_._distributive.LeftDistributiveI<bool, bit.op_.BinaryI1>


	{
		public bool re(nilnul.bit.op_.BinaryI1 plus, nilnul.bit.op_.BinaryI1 multi)
		{

			var x = new nilnul.bit.expr_.Var2();
			var y = new nilnul.bit.expr_.Var2();
			var z = new nilnul.bit.expr_.Var2();

			return nilnul.bit.expr_.closed.be_.Tauto_generi.Singleton.be(
					new nilnul.bit.expr_.call_.Binary_generi(
						bit.op_.binary_.Eq.Singleton
						,


						new nilnul.bit.expr_.call_.Binary_generi(

								multi,
								x
								,
								new nilnul.bit.expr_.call_.Binary_generi(
									plus
									,
									y
									,
									z
								)
							)
						,

						new nilnul.bit.expr_.call_.Binary_generi(

									plus
									,
									new nilnul.bit.expr_.call_.Binary_generi(
										multi,
										x
										,
										y
									)
									,
									new nilnul.bit.expr_.call_.Binary_generi(
										multi,
										x
										,
										z
									)

						)
					)
			);
		}

		public bool re((BinaryI1, BinaryI1) coOps)
		{
			return re(coOps.Item1,coOps.Item2);
		//	throw new NotImplementedException();
		}

		static public LeftDistributive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftDistributive>.Instance;
			}
		}


	}
}
