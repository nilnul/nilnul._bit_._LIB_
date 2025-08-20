using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.and.cumula_
{
	public class NilAsIni
		:
		nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.And>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// true is the unard
		/// </param>
		public NilAsIni(bool initial=false) : base( initial)
		{
		}

		public NilAsIni() : this(false)
		{
		}


		static public NilAsIni Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NilAsIni>.Instance;
			}
		}

	}
}
