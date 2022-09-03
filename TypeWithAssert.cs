using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class TypeWithAssert<T,PredicateSingleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		where PredicateSingleton:nilnul.bit.Assertion<T>,new()
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public TypeWithAssert(T value)
		{
			SingletonByDefaultNew<PredicateSingleton>.Instance.assert(value);
			this.val = value;
			

		}

		static public PredicateSingleton Predicate = SingletonByDefaultNew<PredicateSingleton>.Instance;

		static public T Ensure(ref T x) {
			SingletonByDefaultNew<PredicateSingleton>.Instance.assert(x);
			return x;
			
		}



		
					

	}
}
