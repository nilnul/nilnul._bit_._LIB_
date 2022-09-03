using nilnul.obj._vow;
using System;

namespace nilnul.bit.vow_
{
	[Obsolete()]
	public class True
		:
		True<
		FailException<True>>
		,
		nilnul.obj._vow_.BlankI

	{
		public True(FailException<True> xpn) : base(xpn)
		{
		}

		public True(string s):this(new FailException<True>(s))
		{

		}

		static public void Vow(bool bit, string msg = "")
		{
			_TrueX.Vow(
				bit
				,
				new nilnul.obj._vow.FailException<False>(msg)
			);
		}
	}
}
