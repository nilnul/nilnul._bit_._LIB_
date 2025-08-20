using nilnul.obj.of_;
using nilnul.obj.of_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.ne
{
	public class Cumulator
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.Ne>
		,
		nilnul.obj.op_.binary.cumulator._cumulate_.OfSeq<bool>

	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// false is the unard
		/// </param>
		public Cumulator(bool initial=false) : base( initial)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Cumulator():this(false)
		{
				
		}


		static public Cumulator Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator>.Instance;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// this can be used to:
		///		a variable with the initial. 
		/// </remarks>
		/// <param name="seq"></param>
		/// <returns></returns>
		[MethodImpl(methodImplOptions:MethodImplOptions.AggressiveInlining)]
		public bool cumulate(IEnumerable<bool> seq)
		{
			return seq.Aggregate(this.initial,(a,c) => this.binder.op(a,c));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// <see cref="eq.cumulator_.NilAsSeed.Toggle(ref bool)"/>
		static public bool OfInt(int x) {
			/// 0 is the unard for xor.
			/// hence 1 !=0  => 1
			///		  0 !=0 => 0
			return x != 0;
		}
	}
}
