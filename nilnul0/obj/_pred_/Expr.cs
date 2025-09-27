using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._pred_
{
	/// <summary>
	/// re: (x,y) => x+y*z = 2+w
	///		the part after "=>"
	/// </summary>
	public interface OutputI<T>
		:nilnul.obj._func_.OutputI<T>
		where T: nilnul.bit._expr_.BlankI
	{
	}
}
