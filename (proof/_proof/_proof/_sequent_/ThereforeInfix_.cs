using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._proof._sequent_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// also known as NowThat
	/// </remarks>
	public class ThereforeInfix_
	{
		public const char Right_Tack = '\u22A2';//⊢
		public const char Assertion = '\u22A6'; // assertion sign(⊦). this sign shall be understood as entails (note the tail) graphically. And the left to the sign is bar(|), which means that the left is a set to be merged as a whole to be taken as premise

		public const char Therefore = '\u2234';//∴     (HTML &#8756; · 

		public static string Default =Therefore.ToString();
	}
}
