using nilnul.bit.op_.binary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.bi_.le
{
	/// <summary>
	/// 
	/// </summary>
	public class Cumulator
		: nilnul.obj.op_.binary.cumulator_.OpDefault<bool, bit.op_.binary_.Le>
	{
		public Cumulator(bool initial) : base(initial)
		{
		}
	}
}
