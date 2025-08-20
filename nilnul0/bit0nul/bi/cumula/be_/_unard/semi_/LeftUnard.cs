using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.cumula.be_._unard.semi_
{
	public class LeftUnard
		:

		nilnul.obj.bi.cumula.be_._unard.semi_.ILeftUnard
		,
		nilnul.obj.op_.binary.cumulator.be_._unard.semi_.LeftUnardI<bool?>
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

			return nilnul.bit0nul._SortieX.ARRAY.All(
				r=> obj.binder.op(obj.initial,r) == r

			);

		}

		static public LeftUnard Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftUnard>.Instance;
			}
		}

	}
}
