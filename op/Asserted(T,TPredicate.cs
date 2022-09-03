using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Asserted<T,TPredicate>
	{
		private T _val;
		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		

		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}
		public Asserted(T val,Func<T,bool> func)
		{
			Assert.Eval(val, func);
			this.func = func;
			this.val = val;

		}
		
	
	}
}
