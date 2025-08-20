using nilnul.obj.of_;
using nilnul.obj.of_.binary._cumulator_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.ne.cumulator_
{
	/// <summary>
	/// 
	/// </summary>
	public class OneAsSeed
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.Ne>

	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// </param>
		///

		public OneAsSeed(bool initial=true) : base( initial)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public OneAsSeed():this(true)
		{
				
		}


		static public OneAsSeed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OneAsSeed>.Instance;
			}
		}

		/// <summary>
		/// 1^x = !x
		/// this can be used to toggle x, like:
		///		x^=1
	
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <returns></returns>
		static public void Toggle(ref bool x)
		{
			x^=true;
			/// can also be achieved by:
			/// x = !x;
		}
	}
}
