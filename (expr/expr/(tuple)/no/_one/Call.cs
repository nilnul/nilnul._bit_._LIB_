using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;

namespace nilnul.bit.expr.stati.no._one
{

		public class Call: 
		bit.expr.stati.no.Call
	//	nilnul.obj.expr.stati.no.Call< bool>
			//,StatiI
		{
		static public Call Singleton = SingletonByDefault<Call>.Instance;



		public Call(
					
			)
				:base(bit.no.op.On.Singleton as bit.no.OpI)
			{

			}

		//Set VarsI.vars
		//{
		//	get
		//	{
				
		//		return new bit.var.stati.Set();
		//		throw new NotImplementedException();
		//	}
		//}

		//public StatiI substitue(Stati var, StatiI expr)
		//{
		//	return this;
		//	throw new NotImplementedException();
		//}
	}
	
}
