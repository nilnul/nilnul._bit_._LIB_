using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///	alias:
	///		checklist
	/// </remarks>
	///
	[Obsolete()]
	public class Poll : nilnul.obj.dict_.Poll<nilnul.bit.VarI1,  nilnul.bit.var.Eq>
	{
		public Poll(Dictionary<VarI1, bool> dict):base(dict)
		{
		}
		public Poll():this(new Dictionary<VarI1, bool>())
		{

		}
	}
}
