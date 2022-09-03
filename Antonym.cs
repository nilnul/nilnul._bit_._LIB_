using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Antonym<T>:PredicateI<T>
	{
		PredicateI<T> _property;
		PredicateI<T> property {
			get {
				return _property;
			}
			set {
				_property = value;
			}
		
		}


		public Antonym(PredicateI<T> p)
		{
			this._property = p;
		}


		public Antonym(Func<T,bool> func)
			:this(new Predicate<T>(func))
		{
		}
					


		public bool is_(T obj)
		{
			return !property.is_(obj);
		}
	}
}
