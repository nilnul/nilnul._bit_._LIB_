using nilnul.obj.of_.binary;
using System.Collections.Generic;

namespace nilnul.bit.str.be_
{
	/// <summary>
	/// <see cref="nilnul.bit.bi_.eq.Cumulator.Singleton"/>.
	/// 
	/// </summary>
	/// <remarks>
	/// consider:
	///		0 = 0
	///		0~ 0 =1
	///		0~0~0 = 0
	/// ,but as 1 is unard, so 1 is not important. 1s can be removed. parity of 0s being even.
	/// 
	///    
	///		
	/// []:1
	/// [0]:0
	/// [1]:1
	/// [0,1]:0
	/// [1,0]: 0
	/// [0,0]: 1
	/// [1,1]: 1
	/// </remarks>
	/// alias:
	///		nils parity
	///			, note: one 0s would always be 0;
	///		parity of 0s.
	///		nilsEven
	///			, mnemonic: a single nil would be nil.
	///		nils cardinality
	///		nils toggle
	///
	/// vs:
	///		not (parity of not nils).

	static public class _NilsParityX
	{
		static public bool Be(/*params*/ IEnumerable<bool> bools) {
			return bit.bi_.eq.Cumulator.Singleton.Cumulate(bools);
		}
	}



}
