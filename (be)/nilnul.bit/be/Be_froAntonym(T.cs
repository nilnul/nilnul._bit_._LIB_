using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Be_froAntonymBe<T>
		:nilnul.bit.Be_froDualFunc<T>
	{
		public Be_froAntonymBe(BeI<T> be)
			:base(be.be)
		{

		}

	}
}
