using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.eq
{
	public class Cumulator
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.Eq>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// true is the unard
		/// </param>
		public Cumulator(bool initial=true) : base( initial)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Cumulator() : this(true)
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
