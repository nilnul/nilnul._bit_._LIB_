using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class FroFunc<T>
		:
		BeI<T>
	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public FroFunc(Func<T,bool> func)
		{
			this.func = func;
		}


		#region static

		static public FroFunc<T> Create(Func<T,bool> func) {
			return new FroFunc<T>(func);
		
		}

		static public FroFunc<T> CreateInverse(Func<T, bool> func)
		{
			return new FroFunc<T>(c=>!func(c));

		}
					


		#endregion




		public bool be(T obj)
		{
				return func(obj);
		}
	}
}
