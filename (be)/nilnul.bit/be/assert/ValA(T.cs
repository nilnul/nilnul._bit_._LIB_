using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be.assert
{
	public  abstract partial class ValA<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}


		public abstract Assert2<T> assert
		{
			get;
		}
		

		public ValA(T val)
		{
			assert.assert(val);
			this._val = val;

		}
	}
}
