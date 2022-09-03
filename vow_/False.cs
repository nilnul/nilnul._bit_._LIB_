using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow;
using nilnul.obj_.xpn_;

namespace nilnul.bit.vow_
{

	public class False
		:
		nilnul.obj._vow_.BlankI
	{
		static public void Vow(bool bit, string msg="") {
			_FalseX.Vow(
				bit
				,
				new nilnul.obj._vow.FailException<False>(msg)
			);
		}

	}
}
