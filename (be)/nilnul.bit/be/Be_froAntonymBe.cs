using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Be_froAntonymBe<T,TBe>
		:nilnul.bit.Be_froDualFunc<T>
		where TBe:BeI<T>,new()
	{
		public Be_froAntonymBe()
			:base(SingletonByDefaultNew<TBe>.Instance.be)
		{

		}

	}
}
