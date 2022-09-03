using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be.assert.ed
{
	public partial class Suite<T, TBe>
		where TBe : BeI<T>, new()
	{
		static public TBe Be = SingletonByDefaultNew<TBe>.Instance;

		static public Assert<T, TBe> AssertInstance = SingletonByDefaultNew<Assert<T, TBe>>.Instance;
		public class Assert
			: nilnul.bit.be.Assert<T, TBe>
		{
			static public Assert Instance = SingletonByDefaultNew<Assert>.Instance;




		}

		public class Ed
			: be.assert.Ed<T, TBe>
		{
			public Ed(T val)
				: base(val)
			{

			}


		}


	}
}
