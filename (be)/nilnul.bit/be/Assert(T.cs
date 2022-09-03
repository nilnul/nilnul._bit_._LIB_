using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assert<T>

	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}
		public Assert(Func<T,bool> func)
		{
			this.func = func;

		}


		
		/// <summary>
		/// return void or exception.
		/// </summary>
		/// <param name="val"></param>
		public void eval(T val) {
			Assert.Eval(val, func);
					
		}

		static public Assert<T> Dual(Func<T,bool> func) {

			return new Assert<T>(c=>!func(c));
		
		}

	
	}
}
