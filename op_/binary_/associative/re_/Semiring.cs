using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_.associative.re_
{
	public class Semiring
		:
		nilnul.obj.ReI<
			nilnul.bit.op_.binary_.AssociativeI
		>
	{
		public bool _re_assumeAssociatives(BinaryI1 a, BinaryI1 b)
		{
			

			return nilnul.bit.op_.binary.re_.Distributive.Singleton.re(
				a,b
			);

		}

	



		public bool re(AssociativeI a, AssociativeI b)
		{
			return _re_assumeAssociatives(a.ee.ee,b.ee.ee);
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
