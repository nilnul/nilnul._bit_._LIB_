using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.form.trio
{
	[Obsolete()]
	public class Call:nilnul.obj.form.trio.Call<bool>
	{
		public Call(
			bit.trio.OpI op,

			bit.FormI arg
			,bit.FormI arg1
			,bit.FormI arg2
				
		)
			:base(op, arg,arg1,arg2 )
		{

		}
	}
}
