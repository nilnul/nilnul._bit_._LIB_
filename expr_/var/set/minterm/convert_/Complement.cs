using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.set.minterm.convert_
{
	/// <summary>
	/// 
	/// eg: ! m1 = ! ( !x & y) 
	/// the complement of it is x & !y
	/// that is, the unappeared x appears in the complement
	/// </summary>
	/// <remarks>
	/// it seems there are no good application of this op
	/// </remarks>
	public interface ComplementI {

	}
	/// <summary>
	/// the
	/// </summary>
	public class Complement : nilnul.obj.Box<nilnul.bit.var.Set1>
	{
		public Complement(Set1 val) : base(val)
		{
		}


	}
}
