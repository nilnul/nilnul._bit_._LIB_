using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._theorem._thesis._proof._infer_
{
	/// <summary>
	/// for natural inference, this is equivalent to "=>"
	/// for axiomatic inference, this is not equivalent to "=>"
	/// the verb form of this concept is: cause
	/// </summary>
	/// <remarks>
	/// also known as NowThat, argument
	/// </remarks>
	public class So_
	{
		public const char Right_Tack = '\u22A2';//⊢
		public const char Assertion = '\u22A6'; // assertion sign(⊦). this sign shall be understood as entails (note the tail) graphically. And the left to the sign is bar(|), which means that the left is a set to be merged as a whole to be taken as premise

		public const char Therefore = '\u2234';//∴     (HTML &#8756; · 

		public static string Default =Therefore.ToString();
	}
}
