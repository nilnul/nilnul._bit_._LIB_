using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AssertionFroAdjSingleton2<TNoun,TAdjectiveSingleton>
		:Assertion_FroAdj2<TNoun>
		where TAdjectiveSingleton:AdjectiveI3<TNoun>,new()
	{
		public AssertionFroAdjSingleton2()
			:base(new TAdjectiveSingleton())
		{
			
		}



		static public AssertionFroAdjSingleton2<TNoun, TAdjectiveSingleton> Instance = SingletonByDefaultNew<AssertionFroAdjSingleton2<TNoun, TAdjectiveSingleton>>.Instance;




		
					
	}
}
