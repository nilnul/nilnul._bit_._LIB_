using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.deduction._proof
{
	/*Sequent calculus is, in essence, a style of formal logical argumentation where every line of a proof is a conditional tautology (called a sequent by Gerhard Gentzen) instead of an unconditional tautology.
	A1,A2,...,An  |=  B

		 */

		/// <summary>
		/// 
		/// </summary>
		/// <seealso cref="Cirquent"/>
		/// <remarks>
		///自然语言说“下雨必拥堵”时，默认只在下雨为真的情况下讨论问题，即：下雨 |- 拥堵。
		///但是逻辑学家说“下雨必拥堵”时，是考虑不下雨时的情况的，即 下雨 -> 拥堵。
		/// </remarks>
	class Sequent
	{
	}
}
