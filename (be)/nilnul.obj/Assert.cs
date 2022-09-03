using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	public partial class Assert1<T>
	:

	nilnul.obj.Assert1<T, BI<T>>


	{


		public Assert1(BI<T> b)
			: base(b)
		{

		}


	}

	public partial class Assert_TbDefault1<T, TB>
	:

	nilnul.obj.Assert1<T, TB>


	where TB : BI<T>, new()

	{

		static public Assert_TbDefault1<T, TB> Singleton = SingletonByDefault<Assert_TbDefault1<T, TB>>.Instance;


		public Assert_TbDefault1()
			: base(SingletonByDefault<TB>.Instance)
		{

		}

		static public void Assert(T obj) {
			Singleton.assert(obj);
		}


	}




	public partial class Assert1<T, TB>
: nilnul.obj.AssertI<T>
where TB : BI<T>
	{


		private TB _b;

		public TB b
		{
			get { return _b; }
			set { _b = value; }
		}


		public Assert1(TB b)
		{
			_b = b;
		}

		public void assert(T obj)
		{
			nilnul.bit.Assert.True(
				_b.be(obj)
			);
			return;

			throw new NotImplementedException();
		}
	}


}
