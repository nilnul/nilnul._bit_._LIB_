using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_
{
	public class Ternary
		:
		nilnul.obj.op_.Ternary<bool>,

		bit.op_.TernaryI
		,
		op_.of_.VecI
		

	{
		public Ternary(Func<bool, bool,bool, bool> val) : base(val)
		{
		}

		static public implicit operator Ternary(Func<bool, bool,bool,bool> x)
		{
			return new Ternary(x);
		}
		static public Ternary Of(TernaryI x)
		{
			return x is Ternary	 y ? y : new Ternary(x.op);
		}

	}

}
