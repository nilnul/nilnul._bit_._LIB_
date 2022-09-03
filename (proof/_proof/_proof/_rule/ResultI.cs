using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E= nilnul.bit.ExprI_membered;

namespace nilnul.bit._proof._rule
{

	public interface ResultI
	{
		/// <summary>
		/// if the result is 1 equiv q, the q is a theorem as well.
		/// if the result is 1 -> q, then for the inference rule:  1->Q is equiv Q. subsitite ( 1->Q ~ Q  , Q, q  ) we get 1->q ~q. replace 1-> q with 1, we get 1~ q.
		/// </summary>
		E result { get; }
	}
}
