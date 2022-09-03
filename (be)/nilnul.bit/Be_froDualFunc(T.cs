using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Be_froDualFunc<T>
		:
		Be<T>
	{
		public Be_froDualFunc(Func<T,bool> func)
			:base(c=>!func(c))
		{
		}

	}
}
