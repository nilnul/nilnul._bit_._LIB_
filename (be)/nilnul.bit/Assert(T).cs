using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Assert<T>
		:nilnul.bit.AssertI<T>
	{
		Func<T, bool> _func;

		public Func<T, bool> func {

			get {
				return _func;
			}
			
		}

		public Assert(Func<T,bool> func)
		{
			this._func = func;
		}



		public void yes(T obj) {

			AssertX.True(_func(obj));
			
		}
		public void no(T obj) { 
			AssertX.False(_func(obj));
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

		static public Assert<T> CreateDual(Func<T,bool> func) {

			return new Assert<T>(nilnul.bit.func.Dual.Eval(func) );
		
		}
					
	}
}
