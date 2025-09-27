using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
/// or be?
/// </summary>
	public interface PredicateI
	{
	}

	public interface PredicateI<T> : PredicateI {
		bool be(T obj);
	}
}
