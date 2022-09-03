using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Absurdity<T>:Axiom<T>
		//where P:PropertyI<T>

	{
		//PropertyI<T> _property;
		//public PropertyI<T> property { get {
		//	return _property;
		//}
		//	set {
		//		_property = value;
		//	}
		//}

		public Absurdity(PredicateI<T> p)
			:base(new Antonym<T>(p))
		{
			
		}


					
	}
}
