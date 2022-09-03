using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.nulable.phrase_.null_
{
	static public class _LowerX
	{
		public const string True = "true";
		public const string False = "false";
		public const string NULL = "null";


		static public string Txt(bool? bit) {
			return bit.HasValue? nilnul.bit.phrase_._LowerX.Txt(bit.Value): NULL;
		}



	}

	public class Lower
		: nilnul.bit.nulable.PhraseI
	{
		public string phrase(bool? obj)
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
