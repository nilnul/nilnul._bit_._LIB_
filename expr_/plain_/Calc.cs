using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_
{
	/// <summary>
	/// 
	/// </summary>
	public interface CalcI:nilnul.bit.expr_.PlainI
	{
	}

	public class Calc : call.be_.arithm.En
	{
		public Calc(CallI val) : base(val)
		{
		}
	}
}
