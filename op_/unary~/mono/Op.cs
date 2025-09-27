using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.mono
{
	/// <summary>
	/// 
	/// </summary>
	/// make this abstract such as to make sure all subtypes are sealed types.
	public abstract class Op
		:obj.mono.op.Closed<bool>
		,OpI
	{
		public Op(Func<bool,bool> func)
			:base(func)
		{

		}
	}

	public interface OpI : obj.mono.OpI<bool>
		,bit.OpI
	{

	}
}
