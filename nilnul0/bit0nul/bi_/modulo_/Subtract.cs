using System;

namespace nilnul.bit0nul.bi_.modulo_
{
	/// <summary>
	/// modulo subtract
	/// </summary>
	/// alias:
	///		minus
	///		subtract
	public class Subtract : bit0nul.BiI
	{
		public bool? op(bool? par, bool? par1)
		{
			return nilnul.bit0nul.of_._OfIntX.OfLeTwo(
				(
					3
					+
					bit0nul.to_._ToNumX.ToNum(par)
					-
					bit0nul.to_._ToNumX.ToNum(par1)
				)
				%
				3
				
			);
		}


		static public Subtract Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Subtract>.Instance;
			}
		}

	}





}
