using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AssertionFroAdjSingleton<TNoun,TAdjectiveSingleton>
		:Assertion_FroAdj<TNoun>
		where TAdjectiveSingleton:AdjectiveI2<TNoun>,new()

	{
		

		public AssertionFroAdjSingleton()
			:base(new TAdjectiveSingleton())
		{
			
		}



		static public AssertionFroAdjSingleton<TNoun, TAdjectiveSingleton> Instance = SingletonByDefaultNew<AssertionFroAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;




		
					
	}
}
