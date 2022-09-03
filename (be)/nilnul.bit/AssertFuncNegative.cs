using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	[Obsolete()]
	public partial class FuncNegative<TInput>
		:Assert<TInput>
	{

		private Func<TInput,bool> _func;

		public Func<TInput,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}


		public FuncNegative(Func<TInput,bool> func)
			:base(Predicate.ToNegative(func))
		{

		}
					

					
	}
}
