using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._proposal_
{
	public class ProveInfixSymbol
	{
		public const char DoubleTurnStile ='\u22a8';//In Unicode it is encoded at U+22A8 

		public const char Entail = '\u22a6';//[4] (Code point U+22A6 is named assertion sign(⊦).) 

		/// <summary>
		/// the proposisal is either true or false. But before proof, we don't know whether it's true of false. So proposal can be represented by a variable{bit} 
		/// </summary>
		public static string Default = Entail.ToString();
	}
}
