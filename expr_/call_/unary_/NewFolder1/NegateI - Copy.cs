using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.bit.var;

namespace nilnul.bit.expr_.call_.unary_
{

	[Obsolete()]
	public interface NegI:UnaryI
	{

	}

	[Obsolete()]
	public class Neg :
		Unary1,


		NegI
	{
		public Neg(op_.UnaryI op, ExprI2 x) : base(op, x)
		{
		}



		
	}


}
