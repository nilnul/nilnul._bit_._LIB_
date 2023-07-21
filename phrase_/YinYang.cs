using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.phrase_
{
	public class YinYang :
		nilnul.obj_.singular.Heir<YinYang>
		,
		bit.PhraseI
		,
		IDigram
	{

		public string phrase(bool obj)
		{
			return obj ? _DigramX.YIN : _DigramX.YANG;
		}
	}
}
