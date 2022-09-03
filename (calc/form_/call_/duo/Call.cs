using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.form.duo
{
	public class Call:nilnul.obj.form.duo.Call_staticTyped<bool>
	{
		public Call(
			bit.duo.OpI op,

			bit.FormI arg
			,bit.FormI arg1
				
		)
			:base(op, arg,arg1 )
		{

		}
	}
}
