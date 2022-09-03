using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj.assertion
{
	public partial class FroAdj<T,TAdj>
		:FroAdj<T>
		where TAdj:AdjI<T>,new()
	{
		public FroAdj()
			:base(new TAdj())
		{
			
		}



		static public FroAdj<T, TAdj> Instance = SingletonByDefaultNew<FroAdj<T, TAdj>>.Instance;




		
					
	}
}
