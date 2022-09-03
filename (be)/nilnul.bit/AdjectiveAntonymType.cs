using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AdjectiveAntonymType<TNoun,TAdjectiveSingleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		:AdjectiveType<TNoun,Adjective_FroAntonym<TNoun,TAdjectiveSingleton>>

		where TAdjectiveSingleton:nilnul.bit.AdjectiveI2<TNoun>,new()
	{
		

		

		public AdjectiveAntonymType(TNoun value)
			:base(value)
		{


		

		}


		

		
					

	}
}
