using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assert2<T>
		:nilnul.bit.Assert<T>
	{
		public Assert2(BeI<T> be)
			:base(be.be)
		{

		}

		static public Assert2<T> CreateDual(BeI<T> be) {
			return new Assert2<T>( new Be_froAntonymBe<T>(be)  );
		
		}


	

	
	}
}
