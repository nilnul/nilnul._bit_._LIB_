using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete()]
	public partial class Asserted<T, TB>
		where TB : BI<T>, new()
	{
		static public Assert_TbDefault1<T, TB> Assert = SingletonByDefaultNew<Assert_TbDefault1<T, TB>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}


		public Asserted(T val)
		{
			Assert.assert(val);
			this._val = val;

		}
	}



}
