using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.bi.cumula_
{
	public class Falsy : Cumulator
	{
		public Falsy( BinaryI<bool?> accumulator) : base(false, accumulator)
		{
		}
	}
}
