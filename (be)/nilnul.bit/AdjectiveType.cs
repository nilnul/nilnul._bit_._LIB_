using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AdjectiveType<TNoun,TAdjectiveSingleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		where TAdjectiveSingleton:nilnul.bit.AdjectiveI2<TNoun>,new()
	{
		private TNoun _val;

		public TNoun val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public AdjectiveType(TNoun value)
		{


			Assert(value);
			this.val = value;

		}

		public override string ToString()
		{
			return _val.ToString();
		}


		static public void Assert(TNoun val){

			AssertDeny.assert(val);
			
		}

		static public AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton> AssertDeny = SingletonByDefaultNew<AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;

		static public TNoun Ensure(ref TNoun x) {
			Assert(x);
			return x;
			
		}

		static public AdjectiveType<TNoun, TAdjectiveSingleton> Create(TNoun x) {
			return new AdjectiveType<TNoun, TAdjectiveSingleton>(x);
		}


		static public AssertionFroAdjSingleton<TNoun, TAdjectiveSingleton> Assertion =SingletonByDefaultNew<AssertionFroAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;

		
					

	}
}
