using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Predicate
	{



		static public Func<TInput, bool> ToNegative<TInput>(Func<TInput, bool> func)
		{
			return x => !func(x);
		}

	}
}
