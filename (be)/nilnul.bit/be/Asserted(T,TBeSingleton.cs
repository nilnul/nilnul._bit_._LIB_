using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Asserted<T,TBe_singleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		:nilnul.bit.be.Asserted<T>

		where TBe_singleton:nilnul.bit.BeI<T>,new()

	{
		static public TBe_singleton Predicate = SingletonByDefaultNew<TBe_singleton>.Instance;

		static public AssertionI<T> Assertion = SingletonByDefaultNew<be.Assertion<T, TBe_singleton>>.Instance;

	

		public Asserted(T val)
			:base(val,SingletonByDefaultNew<TBe_singleton>.Instance.be)
		{
			

		}
		[Obsolete()]
		protected Asserted()
			:base(SingletonByDefaultNew<TBe_singleton>.Instance.be)
		{

		}

		public Asserted(Asserted<T,TBe_singleton> x)
			:base(Predicate.be)
			
		{
			this.valSetter = x.val;



		}

		



		static public T Ensure(ref T x) {
			Assertion.assert(x);
			return x;
			
		}

					

	}
}
