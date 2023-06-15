using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	public class Binary
		:
		nilnul.obj.op_.Binary<bool>,

		bit.op_.BinaryI1
		,
		op_.of_.VecI

	{
		public Binary(Func<bool, bool, bool> val) : base(val)
		{
		}

		static public implicit operator Binary(Func<bool,bool, bool> x)
		{
			return new Binary(x);
		}
		static public Binary Of(BinaryI1 x)
		{
			return x is Binary y ? y : new Binary(x.op);
		}

	}

}
