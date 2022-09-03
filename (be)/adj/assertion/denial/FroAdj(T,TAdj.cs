using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj.assertion.denial
{
	public partial class FroAdj<T,TAdj>
		:assertion.FroAdj<T>
		where TAdj:AdjI<T>,new()

	{
		public FroAdj()
			:base(new bit.adj.FroAntonym<T,TAdj>())
		{

		}
		



	}
}
