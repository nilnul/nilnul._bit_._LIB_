using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi_.logic_
{
	/// <summary>
	/// take two as nul
	/// </summary>
	public class TwoAsNul
		: nilnul.obj.Box_ofIn<bit.BiI>
		,
		nilnul.bit0nul.BiI
	{
		public TwoAsNul(in bit.BiI val) : base(val)
		{
		}

		public TwoAsNul(bit.BiI x) : base(x)
		{
		}

		public bool? op(bool? par, bool? par1)
		{
			if (par is null || par1 is null)
			{
				return null;
			}
			return boxed.op(par.Value,par1.Value);
			//throw new NotImplementedException();
		}
	}
}
