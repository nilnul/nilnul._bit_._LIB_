using System;

namespace nilnul.bit0nul.bi_.modulo_
{
	/// <summary>
	/// modulo pow
	/// </summary>
	public class Pow : bit0nul.BiI
	{
		public bool? op(bool? par, bool? par1)
		{
			if (par ==false)	///0
			{
				if (par1 == false)
				{
					return true;
				}
				return false;
			}
			if (par == true)	/// 1
			{
				return true;
			}

			/// 2 as base:
			///
			if (par1 ==true)
			{
				return null;
			}
			//if (par1 == false )
			//{
			//	return true;
			//}
			/// 2^2 = 4  which is 1 modulo 3.
			///
			return true;

		}


		static public Pow Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Pow>.Instance;
			}
		}

	}



}
