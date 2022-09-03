using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	 public partial class AdjectiveTowardNoun<T,TAdj>
		where TAdj:AdjectiveI2<T>,new()
	{
		public class Assertion
			: nilnul.bit.AssertionFroAdjSingleton<T, TAdj>
		{

		}

		public class Noun
			: nilnul.bit.AdjectiveType<T, TAdj>
		{

			public Noun(T bag)
				: base(bag)
			{
			}


		}

		public class NounAntonym
			: nilnul.bit.AdjectiveAntonymType<T, TAdj>
		{

			public NounAntonym(T bag)
				: base(bag)
			{
			}


		}


	}

}
