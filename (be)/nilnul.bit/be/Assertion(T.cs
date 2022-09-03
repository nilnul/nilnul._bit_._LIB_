using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assertion<T>
		:
		assertion.FroFunc<T>
		
	{


		public Assertion(BeI<T> be)
			:base(be.be)
		{
			
		}





	}
}
