using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AssertDeny_byAdjSingleton<TNoun,TAdjectiveSingleton>
		:AssertDeny_byAdj<TNoun>
		where TAdjectiveSingleton:AdjectiveI2<TNoun>,new()

	{
		

		public AssertDeny_byAdjSingleton()
			:base(new TAdjectiveSingleton())
		{
			
		}

		static public AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton> Instance = SingletonByDefaultNew<AssertDeny_byAdjSingleton<TNoun, TAdjectiveSingleton>>.Instance;


		
					
	}
}
