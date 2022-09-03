using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.form.mono
{
	public class Call:nilnul.obj.form.mono.Call_staticTyped<bool>
	{
		public Call(
			bit.mono.OpI op,

			bit.FormI form
				
		)
			:base(op, form )
		{

		}
	}
}
