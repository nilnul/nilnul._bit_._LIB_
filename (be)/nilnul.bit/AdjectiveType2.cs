using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AdjectiveType2<TNoun,TAdjectiveSingleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		where TAdjectiveSingleton:nilnul.bit.AdjectiveI3<TNoun>,new()
	{
		private TNoun _val;

		public TNoun val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public AdjectiveType2(TNoun value)
		{
			Assert(value);
			this.val = value;

		}

		public override string ToString()
		{
			return _val.ToString();
		}


		static public void Assert(TNoun val){
			Assertion.assert(val);
			
		}

		//static public AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton> AssertDeny = SingletonByDefaultNew<AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;

		static public TNoun Ensure(ref TNoun x) {
			Assert(x);
			return x;
			
		}

		static public AdjectiveType2<TNoun, TAdjectiveSingleton> Create(TNoun x) {
			return new AdjectiveType2<TNoun, TAdjectiveSingleton>(x);
		}


		static public AssertionFroAdjSingleton2<TNoun, TAdjectiveSingleton> Assertion =SingletonByDefaultNew<AssertionFroAdjSingleton2<TNoun, TAdjectiveSingleton>>.Instance;

		
					

	}
}
