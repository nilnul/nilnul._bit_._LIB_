using nilnul.obj;
using nilnul.obj.bi._cumula_;
using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.and
{
	public class Cumulator
		:
		nilnul.bit.bi.cumula_.OpDefault<bit.bi_.And>

		///nilnul.obj.of_.binary.cumulator_.OpDefault<bool,bi_.And>
		,
		nilnul.obj.bi.CumulaI<bool>
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

		//BiI<bool> BinderI<BiI<bool>>.binder => this.binder;
	}
}
