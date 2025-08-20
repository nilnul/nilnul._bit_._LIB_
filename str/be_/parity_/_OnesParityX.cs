using nilnul.obj.of_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str.be_
{
	/// <summary>
	/// <see cref="nilnul.bit.bi_.ne.Cumulator.Singleton"/>
	/// </summary>
	/// <remarks>
	/// cuz 0 being unard(<see cref="nilnul.obj.bi.cumulator.be_"/>) can be removed, then we need only consider 1s.
	/// two 1s would become 0 to be cancelled. one 1s would be one.
	/// So this is whether 1s would be odd.
	///		
	/// []:0
	/// [0]:0
	/// [1]:1
	/// [0,1]:1
	/// [1,0]: 1
	/// [1,1]: 0
	/// </remarks>
	/// alias:
	///		ones parity
	///			,note: one 1 would always be 1.
	///		ones toggle
	/// vs:
	///		
	///		equiv: not ( nilsParity of notOnes)
	internal class _OnesParityX
	{
		static public bool Be(/*params*/ IEnumerable<bool> bools)
		{
			return bit.bi_.ne.Cumulator.Singleton.Cumulate(bools);
		}

	}



}
