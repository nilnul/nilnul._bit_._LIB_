using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_.max
{
	public class Cumulator : obj.op_.binary.cumulator_.OpDefault<bool, op_.binary_.Max>
	{
		public Cumulator() : base(false)
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
