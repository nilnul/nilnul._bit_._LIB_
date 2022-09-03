using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.phrase_
{
	static public class _LowerX
	{
		public const string True = "true";
		public const string False = "false";

		static public string Txt(bool bit) {
			return bit ?True: False;
		}



	}

	public class Lower
		: nilnul.bit.PhraseI
	{
		public string phrase(bool obj)
		{
			return _LowerX.Txt(obj);
			//throw new NotImplementedException();
		}


		static public Lower Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lower>.Instance;
			}
		}



	}
}
