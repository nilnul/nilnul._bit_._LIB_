using nilnul.bit0nul.to_.dich_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi_.logic_
{
	/// <summary>
	/// take two as true, as two, like one, is not nil
	/// </summary>
	public class TwoAsNonnil
		: nilnul.obj.Box_ofIn<bit.BiI>
		,
		nilnul.bit0nul.BiI
	{
		public TwoAsNonnil(in bit.BiI val) : base(val)
		{
		}

		public TwoAsNonnil(bit.BiI x) : base(x)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool? op(bool? par, bool? par1)
		{
			return opAsBit(par,par1);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <returns></returns>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool opAsBit(bool? par, bool? par1)
		{
			return boxed.op(par.TwoAsNonnil(),par1.TwoAsNonnil());
			//throw new NotImplementedException();
		}


	}
}
