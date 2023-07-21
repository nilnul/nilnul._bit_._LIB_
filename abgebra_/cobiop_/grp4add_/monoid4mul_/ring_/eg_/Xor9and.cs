using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_.eg_
{
	///https://en.wikipedia.org/wiki/Algebraic_normal_form
	///
	/// In Boolean algebra, the algebraic normal form (ANF), ring sum normal form (RSNF or RNF), Zhegalkin normal form, or Reed–Muller expansion is a way of writing propositional logic formulas in one of three subforms:
	///		Negations are not permitted:
	///		xor() =0, as 0 is the neutral for xor.
	///		a ^ b ^(a &b) ^ (abc)
	///		xor(  prod()   ) = xor( 1  )=1
	///		prod() ^ a ^(ab)
	///			, where prod() can be written as 1.
	///
	///  
	/// 
	/// <summary>
	/// nilard: 0, as 0^0=0, 0^1=1;
	/// negation: 0^0=0, 1^1=0
	/// oneness: 1, as 1&0=0, 1&1=1;
	/// for nonnil, 1 &1 =1.
	/// annillator: 0 & x =0
	/// </summary>
	internal class Xor9and:IEg
	{
	}

}
