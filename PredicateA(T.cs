using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public abstract partial class PredicateA<T>:PredicateI<T>
	{

		public abstract bool is_(T obj);



		

		public bool no(T obj) {

			return !is_(obj);
		
		}		

		public void assert(T val) {
			AssertX.True(is_(val));
		}

		public T ensure(T x) {
			assert(x);
			return x;
		}



		public void reject(T obj) {
			AssertX.True(no(obj));
		
		}



	
					
		

		


	

	}
}
