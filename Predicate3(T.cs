using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Predicate3<T>
		:
		PredicateI2<T>
	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Predicate3(Func<T,bool> func)
		{
			this.func = func;
		}




		#region static

		static public Predicate3<T> Create(Func<T,bool> func) {
			return new Predicate3<T>(func);
		
		}

		static public Predicate3<T> CreateInverse(Func<T, bool> func)
		{
			return new Predicate3<T>(c=>!func(c));

		}
					


		#endregion




		public bool be(T obj)
		{
				return func(obj);
		throw new NotImplementedException();
		}
	}
}
