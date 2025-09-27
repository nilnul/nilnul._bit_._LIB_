using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// 
	/// </summary>
	/// make this abstract such as to make sure all subtypes are sealed types.
	public abstract class Op
		:nilnul.op.Closed<bool>
		,OpI1
	{
		public Op(Func<bool,bool> func)
			:base(func)
		{

		}
	}

	[Obsolete()]
	public interface OpI1 : nilnul.OpI<bool>
		,bit.OpI_generic
	{

	}
}
