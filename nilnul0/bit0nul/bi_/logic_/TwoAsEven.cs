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
	/// take two as false, like being moduloed
	/// </summary>
	public class TwoAsEven
		: nilnul.obj.Box_ofIn<bit.BiI>
		,
		nilnul.bit0nul.BiI
	{
		public TwoAsEven(in bit.BiI val) : base(val)
		{
		}

		public TwoAsEven(bit.BiI x) : base(x)
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
			return boxed.op(par.TwoAsEven(),par1.TwoAsEven());
			//throw new NotImplementedException();
		}


	}
}
