using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj
{
	public partial class Env<T, TAdj, TEq>

		where TAdj : nilnul.bit.AdjI<T>, new()
		where TEq:IEqualityComparer<T>,new()
	{

		public partial class Noun
		{

			private T _val;

			public T val
			{
				get { return _val; }
				set { _val = value; }
			}



			public Noun(T value)
			{
				Assert(value);
				this.val = value;

			}

			public override string ToString()
			{
				return _val.ToString();
			}


			static public void Assert(T val)
			{
				Assertion.assert(val);

			}

			//static public AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton> AssertDeny = SingletonByDefaultNew<AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;

			static public T Ensure(ref T x)
			{
				Assert(x);
				return x;

			}

			static public Noun<T, TAdj> Create(T x)
			{
				return new Noun<T, TAdj>(x);
			}


			static public assertion.FroAdj<T, TAdj> Assertion = SingletonByDefaultNew<assertion.FroAdj<T, TAdj>>.Instance;

			public partial class Eq
			: IEqualityComparer<Noun>
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







	}
}
