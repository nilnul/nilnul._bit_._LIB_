using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.phrase_
{
	public class YangYin :
		nilnul.obj_.singular.Heir<YangYin>
		,
		bit.PhraseI
	{
		
		public string phrase(bool obj)
		{
			return obj ? _DigramX.YANG :_DigramX.YIN;
		}
	}
}
