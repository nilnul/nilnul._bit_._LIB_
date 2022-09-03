using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Predicate<T1,T2>:PredicateI
	{
		private Func<T1,T2,bool> _func;

		public Func<T1,T2,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Predicate(Func<T1,T2,bool> func)
		{
			this.func = func;
		}

		static public Predicate<T1, T2> CreateNegativeFrom(Func<T1,T2,bool> func) {

			return new Predicate<T1, T2>((c,d)=>!func(c,d));
		
		}

		public bool is_(T1 obj1,T2 obj2)
		{
			return func(obj1,obj2);
		}

		public void assert(T1 obj1,T2 t2) {
			AssertX.True(is_(obj1,t2));
		}

		public bool no(T1 p1,T2 p2) {

			return !is_(p1,p2);
		
		}

		public void reject(T1 a,T2 b) {
			AssertX.True(no(a,b));
		
		}


	

	}
}
