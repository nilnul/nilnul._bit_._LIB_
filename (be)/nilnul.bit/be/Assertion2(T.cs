using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assertion<T>
		:
		AssertionI<T>

	{
		private BeI<T> _predicate;

		public BeI<T> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
	
		

		public Assertion(BeI<T> func)
		{
			this.predicate = func;
		}



		public Assertion(Func<T,bool> func)
			:this(new be.FroFunc<T>(func))
		{
		}

					

		public void assert(T obj) {

			AssertX.True(predicate.be(obj));
			
		}

		public T ensure(ref T obj) {
			assert(obj);
			return obj;
		}
		public void reject(T obj) { 
			AssertX.False(predicate.be(obj));
		}

		public void deny(T obj)
		{
			AssertX.False(predicate.be(obj));
		}

		public void disavow(T obj)
		{
			AssertionNullaryFunc.Disavow(predicate.be(obj));
		}


		public T ensureNot(ref T obj)
		{
			disavow(obj);
			return obj;
		}



	}
}
