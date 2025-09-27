using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.expr.duo.op
{
	public class Nand
	{
		static public Call Eval(ExprI_membered x, ExprI_membered y)
		{
			return new Call(bit.duo.op.Ni.Singleton, x, y);
		}

		static public Call Eval(V x, V y)
		{
			return new Call(bit.duo.op.Ni.Singleton, x, y);
		}


		static public Call Eval(E x, V y)
		{
			return new Call(bit.duo.op.Ni.Singleton, x, y);
		}

		static public Call Eval(V x, E y)
		{
			return new Call(bit.duo.op.Ni.Singleton, x, y);
		}



	}
}
