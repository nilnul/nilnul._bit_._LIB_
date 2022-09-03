using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.lambda_.call_
{
	public class Compo : nilnul.bit.func.combine_.compo.Call
		,
		LambdaI
	{
		public Compo(FuncI2 func, FuncI2 arg) : base(func, arg)
		{
		}
	}
}
