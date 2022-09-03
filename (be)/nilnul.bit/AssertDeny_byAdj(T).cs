using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class AssertDeny_byAdj<T>
		:
		nilnul.bit.AssertDenyI<T>

	{
		private AdjectiveI2<T> _predicate;

		public AdjectiveI2<T> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		

		public AssertDeny_byAdj(AdjectiveI2<T> func)
		{
			this.predicate = func;
		}


		public void assert(T obj) {

			AssertX.True(predicate.be(obj));
			
		}

		public T ensure(T val) {
			assert(val);
			return val;
		}


		public void deny(T obj)
		{
			AssertX.False(predicate.be(obj));
			throw new NotImplementedException();
		}
	}
}
