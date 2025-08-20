using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal._statement_
{
	public class ThereforeInfixSymbol
	{
		public const char DoubleTurnStile ='\u22a8';//In Unicode it is encoded at U+22A8 

		public const char Therefore = '\u2234';//∴     (HTML &#8756; · &there4;).'

		public const char Entail =  '\u22a6';// (Code point U+22A6 is named assertion sign(⊦).) 


		public static string Default = Entail.ToString();
	}
}
