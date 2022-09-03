using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class Asserted1<T, TBe>
		where TBe : BeI<T>, new()
	{
		static public Assert_TbDefault<T, TBe> Assert = SingletonByDefaultNew<Assert_TbDefault<T, TBe>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}


		public Asserted1(T val)
		{
			Assert.assert(val);
			this._val = val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}



}
