using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary
{
	public class Cumulator :
		nilnul.obj.op_.binary.Cumulator<bool>
	{
		public Cumulator(bool initial, BinaryI<bool> accumulator) : base(initial, accumulator)
		{
		}

	}
}
