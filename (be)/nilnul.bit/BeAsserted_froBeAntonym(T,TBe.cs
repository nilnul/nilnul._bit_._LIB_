using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class BeAsserted_froBeAntonym<T,TBe>
		:
		BeAsserted<
			T
			,
			predicate.FroAntonym<T,TBe>
		>
		where TBe:BeI<T>,new()
	{

		public BeAsserted_froBeAntonym(T val)
			: base(val)
		{

		}
	





	}
}
