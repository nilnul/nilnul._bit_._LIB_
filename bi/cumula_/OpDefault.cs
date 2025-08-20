using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi.cumula_
{
	/// <summary>
	/// 
	/// </summary>
	public class OpDefault<TOp> : bi.Cumula
		where TOp : nilnul.obj.BiI<bool>, new()

	{
		public OpDefault(bool initial) : base(initial, 
			 nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{
		}
	}
}
