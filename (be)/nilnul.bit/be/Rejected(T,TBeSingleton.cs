using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Rejected<T,TBe_singleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>
		:Rejected<T>
		where TBe_singleton:nilnul.bit.BeI<T>,new()

	{
		static public TBe_singleton Predicate = SingletonByDefaultNew<TBe_singleton>.Instance;

		static public AssertionI<T> Assertion = SingletonByDefaultNew<be.Assertion<T, TBe_singleton>>.Instance;

	

		public Rejected(T val)
			:base(val,SingletonByDefaultNew<TBe_singleton>.Instance.be)
		{

			
			this.val = val;
			

		}


		static public T Ensure(ref T x) {
			Assertion.assert(x);
			return x;
			
		}



		
					

	}
}
