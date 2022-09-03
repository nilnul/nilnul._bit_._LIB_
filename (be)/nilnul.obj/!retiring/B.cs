using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{




	/// <summary>
	/// a unary relation.
	/// </summary>
	/// <typeparam name="D"></typeparam>
	public partial class B<D>
		: BI<D>
	{
		private Func<D, bool> _func;

		public Func<D, bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public B(Func<D, bool> func)
		{
			this.func = func;

		}
		public bool be(D d)
		{
			return func(d);
			throw new NotImplementedException();
		}
	}



	public  interface BI<TDomain>
	{
		bool be(TDomain d);
	}
}
