using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.nulable.op_.binary_
{
	/// <summary>
	/// for a real number x,y
	/// sign(x*y) = sign(x) *sign(y)
	/// </summary>
	public class Multi
		: BinaryI
	{
		public bool? op(bool? par, bool? par1)
		{
			if (par is null || par1 is null)
			{
				return null;
			}
			return bit.op_.binary_.Eq.Singleton.op(par.Value, par1.Value);
		}

		static public Multi Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Multi>.Instance;
			}
		}

	}
}
