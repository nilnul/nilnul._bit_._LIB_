using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.predicate
{
	public partial class FroAntonym<T,TPredicateSingleton>
		:
		Be<T>
		where TPredicateSingleton:BeI<T>, new()
	{
		public FroAntonym()
			:base( c=>!SingletonByDefaultNew<TPredicateSingleton>.Instance.be(c))
		{

		}

	
	}
}
