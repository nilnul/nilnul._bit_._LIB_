using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.predicate.unary
{
	public partial class Assertion<T,TBe>
		where TBe:UnaryI<T>,new()
	{
		static public UnaryI<T> Be = SingletonByDefaultNew<TBe>.Instance;
		public void assert(T x) {
			nilnul.bit.op.Assert.Eval(Be.eval(x));
			
		}
	}
}
