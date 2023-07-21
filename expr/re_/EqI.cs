using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI2;

namespace nilnul.bit.expr.re_
{
	/// <summary>
	/// A eq B is-the-same-thing-as: the expr of A iif B is tauto
	/// </summary>
	/// <remarks>
	/// note: the vars of A and the vars of B might differ in the way such that one is the sub of the other.
	/// </remarks>
	public interface EqI:nilnul.obj.ReI<E>
	{
	}
}
