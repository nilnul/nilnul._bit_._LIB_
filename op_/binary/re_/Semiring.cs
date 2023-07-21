using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.re_
{
	public class Semiring
		:
		nilnul.obj.ReI<
			nilnul.bit.op_.BinaryI1
		>
	{
		public bool re(BinaryI1 a, BinaryI1 b)
		{
			if(
				!(
					nilnul.bit.op_.binary.be_.Associative.Singleton.be(
						a
					)
						&& 
					nilnul.bit.op_.binary.be_.Associative.Singleton.be(
						b
					)
				)
			) {
				return false;
			}

			return binary_.associative.re_.Semiring.Singleton._re_assumeAssociatives(a,b);
		}
		public bool re((BinaryI1, BinaryI1) coOps)
		{
			return re(coOps.Item1,coOps.Item2);
			throw new NotImplementedException();
		}


		static public Semiring Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Semiring>.Instance;
			}
		}

	}
}
