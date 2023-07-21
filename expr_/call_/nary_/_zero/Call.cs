using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;

namespace nilnul.bit.expr.no._zero
{

		public sealed class Call: 
		bit.expr.no.Call
		//nilnul.obj.expr.stati.no.Call< bool>
			//,StatiI
		{
		static public readonly Call Singleton = new Call();


		private Call(
					
			)
				:base(bit.no.op.No.Singleton as bit.no.OpI)
			{

			}

		
	}
	
}
