using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Axiom<T>
		
		//where P:PropertyI<T>
	{
		PredicateI<T> property;

		public Axiom(PredicateI<T> property)
		{
			this.property = property;
		}
					

		public bool not(T obj) {
			return !property.is_(obj);
		
		}

		public bool is_(T obj)
		{
			return property.is_(obj);

		}

		public void assert(T obj) {
			AssertX.True(is_(obj));
		}

		public void deny(T obj) {
			AssertX.True(not(obj));
		
		}
		
	}
}
