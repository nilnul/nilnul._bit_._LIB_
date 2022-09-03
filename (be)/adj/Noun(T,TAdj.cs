using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj
{
	public partial class Noun<T,TAdj>

		where TAdj:nilnul.bit.AdjI<T>,new()
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


		static public void Assert(T val){
			Assertion.assert(val);
			
		}

		//static public AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton> AssertDeny = SingletonByDefaultNew<AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;

		static public T Ensure(ref T x) {
			Assert(x);
			return x;
			
		}

		static public Noun<T, TAdj> Create(T x) {
			return new Noun<T, TAdj>(x);
		}


		static public assertion.FroAdj<T, TAdj> Assertion =SingletonByDefaultNew<assertion.FroAdj<T, TAdj>>.Instance;

		
					

	}
}
