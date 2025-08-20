using nilnul.bit.op_;
using nilnul.bit.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi.cumula.be_.gen_
{
	/// <summary>
	/// if the initial is a, then  a^2 =aa = !a;
	/// and !a a = a !a,
	/// and a^3 = !a  a =a =a !a
	/// 
	/// eg:
	///		{xor, 1}, where 1+1 = 0, 1^3 = 1+1+1 =1, 1^0 =0
	/// </summary>
	/// 
	public class Cyclic
		: nilnul.bit.bi.cumula._be_.OfOpI
	{

		/// <remarks>
		///	aa = !a, a!a =a
		///		
		/// when a =0,    00 =1, 01 = 0.
		///		when commutative, 10 =0
		///		,so when 11 =1, it's eq. when 11 =0, it is nor.
		///		
		/// when a =1,   11 =0, 10 = 1
		///		when commutative, 01=1
		///		,so when 00=0, it's xor; when 00 =1, it is nand.
		/// </remarks>
		///

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in Cumula val)
		{
			return
				val.binder.op(val.initial, val.initial) == !val.initial

				&& val.binder.op(val.initial, !val.initial) == val.initial
				&& val.binder.op(!val.initial, val.initial) == val.initial
				;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in Cumulator val)
		{
			return
				val.binder.op(val.initial, val.initial) == !val.initial

				&& val.binder.op(val.initial, !val.initial) == val.initial
				&& val.binder.op(!val.initial, val.initial) == val.initial
				;

		}

		static public Cyclic Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cyclic>.Instance;
			}
		}

	}
}
