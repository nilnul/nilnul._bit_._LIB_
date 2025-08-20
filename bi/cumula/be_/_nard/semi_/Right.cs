using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi.cumula.be_._nard.semi_
{
	public class Right
		:

		nilnul.obj.op_.binary.cumulator.be_._nilard.semi_.right_.byConversing_.LeftNilardDefault<bool,
			nilnul.bit.op_.binary.cumulator.be_._nilard.LeftNilard
		>
		,
		nilnul.obj.BeI1<bit.op_.binary.Cumulator>

	{
		public bool be(bit.op_.binary.Cumulator obj)
		{
			return base.be(
				(CumulatorI<bool> )obj
			);

		}

	

		static public Right Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Right>.Instance;
			}
		}

	}
}
