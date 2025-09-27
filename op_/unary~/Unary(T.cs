using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Unary<T>
		:nilnul.obj.op.Unary<T,bool>
	{
		public Unary(Func<T,bool> func)
			:base(func)
		{

		}
		public Unary(System.Predicate<T> predicate)
			:this(new Func<T,bool>(x=>predicate(x)))
		{

		}

		public partial class Expr
			
		{
			
		}
	}
}
