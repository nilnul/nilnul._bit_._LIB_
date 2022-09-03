using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class BeAsserted<T,TBe>
		:BeAsserted<T>
		where TBe:BeI<T>,new()
	{

		public BeAsserted(T val)
			: base(val, SingletonByDefaultNew<TBe>.Instance.be)
		{

		}
	

		static public BeAsserted<T, predicate.FroAntonym<T,TBe>> Create_froDual(
		 T	val
			
		) 
	
		{
			return new BeAsserted<T, predicate.FroAntonym<T, TBe>  >(val);
		
		}




	}
}
