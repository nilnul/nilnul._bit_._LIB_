using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.assertion
{
	public partial class FroFunc<T>
		:AssertionI<T>
	{
		Func<T, bool> _func;

		public Func<T, bool> func {

			get {
				return _func;
			}
			
		}

		public FroFunc(Func<T,bool> func)
		{
			this._func = func;
		}

	

		public void assert(T obj)
		{

			AssertX.True(_func(obj));

		}
		public void deny(T obj)
		{
			AssertX.False(_func(obj));
		}
		public T ensure(ref T obj) {
			assert(obj);
			return obj;
		}



		public T ensureNot(ref T obj)
		{
			deny(obj);
			return obj;
			throw new NotImplementedException();
		}
	}
}
