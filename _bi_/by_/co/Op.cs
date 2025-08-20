using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo
{
	public abstract  class Op
		: nilnul.obj.duo.op.Closed<bool>, OpI
	{
		public Op(Func<bool,bool,bool> func)
			:base(func)
		{

		}
		
	}
	[Obsolete()]
	public interface OpI
		:nilnul.obj.duo.OpI<bool>
		,bit.OpI
		//,nilnul.duo.OpI<bool>
	{


	}
	public interface OpI1
		:
		bit._op.OpI_generic
		,nilnul.duo.OpI<bool>
	{


	}


}
