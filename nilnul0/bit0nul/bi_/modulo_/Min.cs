using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi_.modulo_
{
	public class Min : bit0nul.BiI
	{
		public bool? op(bool? par, bool? par1)
		{
			return nilnul.bit0nul.of_._OfIntX.OfLeTwo(
				Math.Min(
					bit0nul.to_._ToNumX.ToNum(par)
					,
					bit0nul.to_._ToNumX.ToNum(par1)
				)
			);
		}


		static public Min Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Min>.Instance;
			}
		}

	}



}
