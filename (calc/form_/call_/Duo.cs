using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit.combine_;

namespace nilnul.bit.form_.call_
{
	public class Duo:
		nilnul.obj.call_.Duo<nilnul.bit.CombineI, nilnul.bit.FormI >
		,FormI

	{
		private Nand singleton;

		public Duo(Nand singleton, int v1, int v2)
			:this(singleton,  nilnul.bit.construct_.Integer.Eval(v1),   nilnul.bit.construct_.Integer.Eval(v2))
		{
			
		}

		public Duo(Nand singleton, bool v1, bool v2)
			:this(singleton, new nilnul.bit.form_.call_.No(v1), new nilnul.bit.form_.call_.No(v2) )
		{
			
		}

		public Duo(CombineI op, FormI arg, FormI arg1) : base(op, arg, arg1)
		{
		}

		

		public bool eval()
		{

			return op.eval(arg.eval(),arg1.eval());
			throw new NotImplementedException();
		}
	}
}
