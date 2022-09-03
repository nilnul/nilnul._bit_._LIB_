using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Assertion_FroAdj<T>
		:AssertionI<T>

	{
		private AdjectiveI2<T> _predicate;

		public AdjectiveI2<T> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		public AdjectiveI2<T> adjective
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		

		public Assertion_FroAdj(AdjectiveI2<T> func)
		{
			this.predicate = func;
		}



		public Assertion_FroAdj(Func<T,bool> func)
			:this(new Adjective_FroFunc<T>(func))
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
