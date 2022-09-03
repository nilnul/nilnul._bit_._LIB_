using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Predicated<T,TBe_singleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		where TBe_singleton:nilnul.bit.BeI<T>,new()
	{
		static public TBe_singleton Predicate = SingletonByDefaultNew<TBe_singleton>.Instance;

		static public AssertionI<T> Assertion = SingletonByDefaultNew<be.Assertion<T, TBe_singleton>>.Instance;

		private T _val;

		public T val
		{
			get { return _val; }
			set {
				Assertion.assert(value);
				_val = value; 
			}
		}
	

		public Predicated(T value)
		{
			
			this.val = value;
			

		}


		static public T Ensure(ref T x) {
			Assertion.assert(x);
			return x;
			
		}



		
					

	}
}
