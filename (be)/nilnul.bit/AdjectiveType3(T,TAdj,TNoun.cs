using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AdjectiveType3<T,TAdjectiveSingleton,TNoun>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>
		:AdjectiveType2<T,TAdjectiveSingleton>

		where TAdjectiveSingleton:nilnul.bit.AdjectiveI3<T>,new()

		where TNoun:nilnul.bit.AdjectiveType2<T,TAdjectiveSingleton>
	{
		
		

		public AdjectiveType3(T value)
			:base(value)
		{



		}


	

		static public TNoun Create(T x) {
			return new TNoun();
		}


		static public AssertionFroAdjSingleton2<T, TAdjectiveSingleton> Assertion =SingletonByDefaultNew<AssertionFroAdjSingleton2<T, TAdjectiveSingleton>>.Instance;

		
					

	}
}
