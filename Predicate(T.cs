using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Predicate<T>:


		
		PredicateI<T>
	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Predicate(Func<T,bool> func)
		{
			this.func = func;
		}

		static public Predicate<T> Create(Func<T,bool> func) {
			return new Predicate<T>(func);
		
		}

		static public Predicate<T> CreateInverse(Func<T, bool> func)
		{
			return new Predicate<T>(c=>!func(c));

		}
					

		public bool is_(T obj)
		{
			return func(obj);
		}

		public void assert(T val) {
			AssertX.True(is_(val));
		}

		public T ensure(T x) {
			assert(x);
			return x;
		}

		public bool no(T obj) {

			return !is_(obj);
		
		}

		public void reject(T obj) {
			AssertX.True(no(obj));
		
		}


	

	}
}
