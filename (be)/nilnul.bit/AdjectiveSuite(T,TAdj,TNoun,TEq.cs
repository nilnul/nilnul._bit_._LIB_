using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public abstract partial class AdjectiveSuite<T,TAdj,TEq>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>
		

		where TAdj:nilnul.bit.AdjectiveI3<T>,new()
	//	where TNoun:nilnul.bit.AdjectiveType2<T,TAdj>
		where TEq:IEqualityComparer<T>,new()
		
	{
		////public abstract bool be(NotNull2<T> val);

			

		public class Assertion
			: nilnul.bit.AssertionFroAdjSingleton2<T,TAdj>
		{

		}

		public class Noun
			: nilnul.bit.AdjectiveType2<T, TAdj>
		{

			public Noun(T bag)
				: base(bag)
			{
			}

			public class Eq
				:IEqualityComparer<Noun>
			{

				public bool Equals(Noun x, Noun y)
				{
					return SingletonByDefaultNew<TEq>.Instance.Equals(x.val, y.val);
					throw new NotImplementedException();
				}

				public int GetHashCode(Noun obj)
				{
					return SingletonByDefaultNew<TEq>.Instance.GetHashCode(obj.val);

					throw new NotImplementedException();
				}
			}

		}

		public class NounAntonym
			: nilnul.bit.AdjectiveAntonymType2<T, TAdj>
		{

			public NounAntonym(T bag)
				: base(bag)
			{
			}


		}
	

		
	}
}
