using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.cumulator.be_._nilard
{
	public class LeftNilard
		:

		nilnul.obj.op_.binary.cumulator.be_._nilard.semi_.LeftNilardI<bool>
		,
		nilnul.obj.BeI1<bit.op_.binary.Cumulator>

	{
		public bool be(Cumulator obj)
		{
			return be(
				(CumulatorI<bool> )obj
			);

			
		}

		public bool be(CumulatorI<bool> obj)
		{
			var rightPar = new nilnul.bit.Sortie();

			return rightPar.ee.All(
				r=> obj.binder.op(obj.initial,r) == obj.initial

			);

		}

		static public LeftNilard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftNilard>.Instance;
			}
		}

	}
}
