using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be
{
	public partial class Assertion<T,TBe>
		:
		be.Assertion<T>

		where TBe:BeI<T>,new()
		
	{
	
		

		public Assertion()
			:base(SingletonByDefaultNew<TBe>.Instance)
		{
			
		}





	}
}
