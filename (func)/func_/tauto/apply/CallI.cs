using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func_.tauto.apply
{
	/// <summary>
	/// also known as 代入规则（Substitute Rule）.
	/// 
	/// </summary>
	/// <remarks>
	///  ( a => a||b  iif b|| a  )  as a func is expression tauto in that a||b iif b||a is tauto.
	///  So, 
	///   ( a => a||b  iif b|| a  ) (A) is 代入规则(substitue rule).  this can evaluate to an expression which is still a tauto.
	///   
	/// 
	/// note: by this, we eliminate the necessity of using ExprVar such as A, B.
	/// </remarks>
	public class Call
	{

	}
}
