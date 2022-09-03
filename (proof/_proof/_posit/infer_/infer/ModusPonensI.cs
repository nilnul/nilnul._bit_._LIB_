using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	/// <summary>
	/// If p->q is true and p is true, then q must be true.
		
	///    p->q		!p+q
	///    p			 p
	/// ---			---
	///    q			 q

	

	/// </summary>
	public partial interface ModusPonensI 
		:
		InferenceRuleI
	{
	}
}
