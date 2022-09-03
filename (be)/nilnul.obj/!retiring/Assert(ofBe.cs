using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	

	[Obsolete()]

	public partial class Assert<T>
	:

	nilnul.obj.Assert<T, BeI<T>>


	{


		public Assert(BeI<T> b)
			: base(b)
		{

		}


	}

	[Obsolete()]

	public partial class Assert_TbDefault<T, TB>
	:

	nilnul.obj.Assert<T, TB>


	where TB : BeI<T>, new()

	{

		static public Assert_TbDefault<T, TB> Singleton = SingletonByDefault<Assert_TbDefault<T, TB>>.Instance;


		public Assert_TbDefault()
			: base(SingletonByDefault<TB>.Instance)
		{

		}

		static public void Assert(T obj) {
			Singleton.assert(obj);
		}


	}

	[Obsolete()]


	public partial class Assert<T, TB>
	:nilnul.obj.AssertI<T>
	where TB : BeI<T>
	{


		private TB _b;

		public TB b
		{
			get { return _b; }
			set { _b = value; }
		}


		public Assert(TB b)
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
