using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.cumula.be_._nard.semi_
{
	public class LeftNard
		:

		nilnul.obj.op_.binary.cumulator.be_._nilard.semi_.LeftNilardI<bool?>
		,
		nilnul.obj.BeI1<bit0nul.bi.Cumulator>

	{
		public bool be(Cumulator obj)
		{
			return be(
				(CumulatorI<bool?> )obj
			);

			
		}

		public bool be(CumulatorI<bool?> obj)
		{
			var leftPar =  nilnul.bit0nul._SortieX.ARRAY;

			return leftPar.All(
				r=> obj.binder.op(obj.initial,r) == obj.initial

			);

		}

		static public LeftNard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftNard>.Instance;
			}
		}

	}
}
