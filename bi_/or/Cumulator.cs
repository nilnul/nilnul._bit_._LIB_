using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.or
{
	public class Cumulator
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.Or>
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

	}
}
