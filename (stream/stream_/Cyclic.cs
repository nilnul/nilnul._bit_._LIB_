using nilnul.bit.str.eg;
using nilnul.obj.str_.started_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.stream_
{
	public class Cyclic :
		nilnul.obj.stream_.Cyclic<bool>,

		StreamI

	{
		public Cyclic(OfArr<bool> val) : base(val)
		{
		}

		public Cyclic(bool[] arr) : base(arr)
		{
		}
	}
}
