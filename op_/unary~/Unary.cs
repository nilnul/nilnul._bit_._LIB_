using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Unary
		:Unary<bool>
	{
		public Unary(Func<bool,bool> func)
			:base(func)
		{

		}
		public Unary(System.Predicate<bool> predicate)
			:this(new Func<bool,bool>(x=>predicate(x)))
		{

		}
	}
}
