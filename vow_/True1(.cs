using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow;
using nilnul.obj_.xpn_;

namespace nilnul.bit.vow_
{
	

	public class True1
		:
		True<
		FailException<True1>>
		,
		nilnul.obj._vow_.BlankI

	{
		public True1(FailException<True1> xpn) : base(xpn)
		{
		}

		public True1(string s):this(new FailException<True1>(s))
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
