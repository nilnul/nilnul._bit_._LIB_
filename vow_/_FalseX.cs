using System;

namespace nilnul.bit.vow_
{
	static public class _FalseX
	{
		
		static public void Vow<TXpn>(bool bit, TXpn xpn )
			where TXpn:Exception
		{
			if (bit)
			{
				throw xpn;

			}
		}



	}
}
