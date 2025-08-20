using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{
	/// <summary>
	/// If p=>q is true and q is false, then p must be false.

	///		p=>q		!p+q
	///		!q			!q
	///		---			---
	///		!p			!p

	/// </summary>
	public partial interface ModusTolensI : InferenceRuleI
	{
	}
}
