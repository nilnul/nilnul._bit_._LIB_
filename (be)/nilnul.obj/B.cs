using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	/*extern alias obj;*/
	

	/// <summary>
	/// a unary relation.
	/// </summary>
	/// <typeparam name="D"></typeparam>
	/// 
	[Obsolete(nameof(/*obj::*/nilnul.obj.BeI1<D> ))]
	public  class Be<D>
		: BeI<D>
	{
		private Func<D, bool> _func;

		public Func<D, bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Be(Func<D, bool> func)
		{
			this.func = func;

		}
		public bool be(D d)
		{
			return func(d);
			throw new NotImplementedException();
		}
	}


	[Obsolete()]
	public  interface BeI<TDomain>
	{
		bool be(TDomain d);
	}
}
