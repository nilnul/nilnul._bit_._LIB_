using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	public class Unary
		:
		nilnul.obj.op_.Unary<bool>,

		bit.op_.UnaryI1
		,
		op_.of_.VecI

	{
		public Unary(Func<bool, bool> val) : base(val)
		{
		}

		static public implicit operator Unary(Func<bool, bool> x) {
			return new Unary(x);
		}
		static public Unary Of(UnaryI1 x) {
			return x is Unary y ? y : new Unary(x.op);
		}

	}

}
