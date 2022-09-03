using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// an adjective applicable to T.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>Adjective is a bool function which partitions the objects in the domain in two.Adj is a single variate predicate</remarks>
	public partial interface AdjectiveI3<T>
	{
		bool be(NotNull2<T> val);
	}
}
