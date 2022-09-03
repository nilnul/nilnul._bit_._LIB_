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
	public interface FormI:CallI
	{
	}

	public class Form : call.be_.form.En
	{
		public Form(CallI val) : base(val)
		{
		}
	}
}
