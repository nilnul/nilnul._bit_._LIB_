using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj.assertion.denial
{
	public partial class FroAdj<T>
		:assertion.FroAdj<T>

	{
		public FroAdj(AdjI<T> adj)
			:base(new bit.adj.FroAntonym<T>(adj))
		{

		}
		



	}
}
