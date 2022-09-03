using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	 public partial class AdjectiveTowardNoun2<T,TAdj>
		where TAdj:AdjectiveI3<T>,new()
	{
		public class Assertion
			: nilnul.bit.AssertionFroAdjSingleton2<T, TAdj>
		{
		}

		public class Noun
			: nilnul.bit.AdjectiveType2<T, TAdj>
		{

			public Noun(T bag)
				: base(bag)
			{
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
