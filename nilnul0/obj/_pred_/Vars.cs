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
	public interface InputI<T>
		:nilnul.obj._func_.InputI<T>
		where T: nilnul.obj._func._input_.BlankI
	{
	}
	public interface InputI_sortie<T>
		:nilnul.obj._func_.input_.SortieI <T>
		where T: obj._func.input_.SortieI
	{
	}


}
