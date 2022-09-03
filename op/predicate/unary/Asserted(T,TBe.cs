using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op.predicate.unary
{
	public partial class Asserted<T,TBe>
		where TBe:UnaryI<T>,new()
	{
		static public UnaryI<T> Be = SingletonByDefaultNew<TBe>.Instance;

		static public Assertion<T, TBe> Assertion = SingletonByDefaultNew<Assertion<T, TBe>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public Asserted(T x)
		{
			Assertion.assert(x);
			this._val = x;


		}

	}
}
