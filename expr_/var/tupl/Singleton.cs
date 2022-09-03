using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;


namespace nilnul.bit.var.tupl
{
	public class Singleton:Started
	{

		public Singleton(V v):base(v, new Sans())
		{

		}

		public Singleton():this(new nilnul.bit.Var2())
		{

		}
	}
}
