using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_.min
{
	public class Cumulator : obj.op_.binary.cumulator_.OpDefault<bool, op_.binary_.Min>
	{
		public Cumulator() : base(true)
		{
		}

		static public Cumulator Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator>.Instance;
			}
		}

	}
}
