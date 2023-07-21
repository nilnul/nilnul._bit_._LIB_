using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_.max.cumulator
{
	public class Cumulate
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<bool, max.Cumulator>
	{


		static public Cumulate Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate>.Instance;
			}
		}

	}
}
