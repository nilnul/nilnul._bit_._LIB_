using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	/// <summary>
	/// 对命题进一步抽象，首先称真值可以变化的陈述句为命题变项或命题变元
	/// </summary>
	public partial interface VarI
		:nilnul.obj.VarI2<bool>
		,RefI
		
	{
	}
}
