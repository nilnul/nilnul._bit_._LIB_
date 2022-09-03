using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.op
{
	public partial class Precedence
	{
		/// <summary>
		/// when an expression has two operators on both sides, it's taken by the operator with the small index or the priority. if the two have the same priority, use the left one.
		/// </summary>
		static public Type[] Smaller_Prior = { 
			typeof( unary.Not									 )
			,
			typeof(binary.And)
			,
			typeof(binary.Or)
			,typeof(binary.Imply)
			,typeof(binary.Eq)
		};

	}
}
