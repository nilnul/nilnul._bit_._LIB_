using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Assertion_FroAdj2<T>
		:AssertionI<T>

	{
		private AdjectiveI3<T> _predicate;

		public AdjectiveI3<T> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		public AdjectiveI3<T> adjective
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		

		public Assertion_FroAdj2(AdjectiveI3<T> func)
		{
			this.predicate = func;
		}



		public Assertion_FroAdj2(Func<T,bool> func)
			:this(new Adjective_FroFunc2<T>(func))
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
