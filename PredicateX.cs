using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	static public partial class PredicateX
	{

		static public Predicate<T> Create<T>(Func<T,bool> func) {
			return new Predicate<T>(func);
		
		}

		static public Predicate<T> CreateInverse<T>(Func<T, bool> func)
		{
			return new Predicate<T>(
				ToNegative(
				func)
				
				);

		}


		static public Func<TInput, bool> ToNegative<TInput>(Func<TInput, bool> func)
		{
			return x => !func(x);
		}

	}
}
