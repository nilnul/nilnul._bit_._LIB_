using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public partial class Predicate2<T>
		:
		PredicateA<T>,

		
		PredicateI<T>
	{
		private Func<T,bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Predicate2(Func<T,bool> func)
		{
			this.func = func;
		}



		public override bool is_(T obj)
		{
			return func(obj);
		}

	


		#region static

		static public Predicate2<T> Create(Func<T,bool> func) {
			return new Predicate2<T>(func);
		
		}

		static public Predicate2<T> CreateInverse(Func<T, bool> func)
		{
			return new Predicate2<T>(c=>!func(c));

		}
					


		#endregion

	

	}
}
