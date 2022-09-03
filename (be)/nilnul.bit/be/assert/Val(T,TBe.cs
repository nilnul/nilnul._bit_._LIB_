using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be.assert
{
	public   partial class Val<T,TBe>

		where TBe:BeI<T>,new()
	{
		static public Assert<T,TBe> Assert = SingletonByDefaultNew<Assert<T,TBe>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public Val(T val)
		{
			Assert.assert(val);
			this._val = val;

		}
	}
}
