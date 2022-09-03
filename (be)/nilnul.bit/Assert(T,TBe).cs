using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	[Obsolete("nilnul.bit.be.Assert")]
	public partial class Assert<TObject,TBe>
		:Assertion<TObject>
		where TBe:BeI<TObject>,new()

	{
	

		public Assert()
			:base(new TBe())
		{
			
		}


	
					
	}
}
