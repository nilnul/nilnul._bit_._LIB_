using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.sys._proof.rule.eg
{


	/// <summary>
	/// if the theorems contain:
	///		 () ~ x
	/// then x is also theorem 
	/// 
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// this is not 
	/// </remarks>
	/// 

		[Obsolete("this is not necessary for Theorem ()~x  can be abstracted as    [()~x ] | y  to get y=>y.  whileas ()~x  ~ x (try truthe table) , so apply y=y ( x ), we get x.    ")]
	public class EmptyTruth
	{
		private ExprI_membered _expr;

		public nilnul.bit.ExprI_membered expr
		{
			get { return _expr; }
			set { _expr = value; }
		}



	}
}
