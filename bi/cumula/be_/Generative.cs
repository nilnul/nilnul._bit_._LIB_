using nilnul.bit.op_;
using nilnul.bit.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi.cumula.be_
{
	/// <summary>
	/// if the initial is a, then  a^2 = !a;
	/// eg:
	///		{xor, 1}, where 1+1 = 0, 1^3 = 1+1+1 =1, 1^0 =0
	/// </summary>
	/// <remarks>
	/// if the cumula is also unard, then:
	///  ax = x: aa =a, contradictory.
	/// if the cumula is nard, then:
	///		ax = a: aa =a, contradictory.
	///	the cumula's initial 
	///  x !x = x x x = ?
	///		
	/// </remarks>
	/// <see cref="bit.bi.be_.IIdempotent"/> which is about not only initial, but also the complement of that initial;
	/// 
	public class Generative
		: nilnul.bit.bi.cumula._be_.OfOpI
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in Cumula val)
		{
			return val.binder.op(val.initial, val.initial) == !val.initial;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool be(in Cumulator val)
		{
			return val.binder.op(val.initial, val.initial) == !val.initial;

		}

		static public Generative Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Generative>.Instance;
			}
		}

	}
}
