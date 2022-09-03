using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_.call_
{

	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public interface ArithmI:CallI
	{
	}

	[Obsolete()]
	public class Arithm : call.be_.arithm.En
	{
		public Arithm(CallI val) : base(val)
		{
		}
	}
}
