using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AdjectiveAntonymType2<TNoun,TAdjectiveSingleton>
		//:StaticCreate<TypeWithPredicate2<T,PredicateSingleton>>

		:AdjectiveType2<TNoun,Adjective_FroAntonym2<TNoun,TAdjectiveSingleton>>

		where TAdjectiveSingleton:nilnul.bit.AdjectiveI3<TNoun>,new()
	{

		public AdjectiveAntonymType2(TNoun value)
			:base(value)
		{
		}
	}
}
