using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary_.ne
{
	/// <summary>
	/// 
	/// </summary>
	public class Cumulator : nilnul.obj.op_.binary.Cumulator<bool>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="accumulator"></param>
		public Cumulator( BinaryI<bool> accumulator) : base(
			false	/// as "ne" is modulo-two-plus, hence 0 is its nilard.
			,
			accumulator
		)
		{
		}
	}
}
