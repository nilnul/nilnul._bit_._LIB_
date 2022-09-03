﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj.assertion
{
	public partial class FroAdj<T>
		:AssertionI<T>

	{
		private AdjI<T> _predicate;

		public AdjI<T> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		public AdjI<T> adjective
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		

		public FroAdj(AdjI<T> func)
		{
			this.predicate = func;
		}



		public FroAdj(Func<T,bool> func)
			:this(new FroFunc<T>(func))
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
