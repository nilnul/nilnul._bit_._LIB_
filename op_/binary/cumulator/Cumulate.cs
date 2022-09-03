using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.cumulator
{
	public class Cumulate
		: nilnul.obj.op_.binary.cumulator.Cumulate<bool>
	{
		public Cumulate(CumulatorI<bool> val) : base(val)
		{
		}

		public Cumulate(bool ini, BinaryI<bool> op) : base(ini, op)
		{
		}
	}
}
