using nilnul.obj.of_;
using nilnul.obj.of_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.eq.cumulator_
{
	public class NilAsSeed
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.Eq>

	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// false is the unard
		/// </param>
		///

		public NilAsSeed(bool initial=false) : base( initial)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public NilAsSeed():this(false)
		{
				
		}


		static public NilAsSeed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NilAsSeed>.Instance;
			}
		}

		/// <summary>
		/// 0~x = !x
		/// this can be used to toggle x, like:
		///		<see cref="ne.cumulator_.OneAsSeed.Toggle(ref bool)"/>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <returns></returns>
		static public void Toggle(ref bool x)
		{
			x= (x==false);
			/// can also be achieved by:
			/// x = !x;
		}
	}
}
