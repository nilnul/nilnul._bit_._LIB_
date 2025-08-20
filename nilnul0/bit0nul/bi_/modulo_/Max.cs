using System;

namespace nilnul.bit0nul.bi_.modulo_
{
	public class Max : bit0nul.BiI
	{
		public bool? op(bool? par, bool? par1)
		{
			return nilnul.bit0nul.of_._OfIntX.OfLeTwo(
				Math.Max(
					bit0nul.to_._ToNumX.ToNum(par)
					,
					bit0nul.to_._ToNumX.ToNum(par1)
				)
			);
		}


		static public Max Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Max>.Instance;
			}
		}

	}



}
