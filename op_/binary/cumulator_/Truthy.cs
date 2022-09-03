using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.cumulator_
{
	public class Truthy : Cumulator
	{
		public Truthy( BinaryI<bool> accumulator) : base(true, accumulator)
		{
		}
	}
}
