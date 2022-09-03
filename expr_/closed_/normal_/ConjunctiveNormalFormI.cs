using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.proposition
{

	/// <summary>
	/// 
	/// </summary>
	public partial interface ConjunctiveNormalFormI 
		: 
		PropositionI
		,
		OpOnSetExprI<PropositionI, PropositionI, PropositionI>, NormalFormI

	{
	}
}
