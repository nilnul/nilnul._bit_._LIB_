using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.expr_.PlainI;

namespace nilnul.bit.func.lambda_.call_
{
	public class Apply : nilnul.bit.func.convert_.apply.Call
		,
		LambdaI
	{
		/// <summary>
		/// can be achieved by 
		/// </summary>
		/// <param name="func"></param>
		/// <param name="arg"></param>
		public Apply(FuncI2 func, E arg) : base(func, arg)
		{
		}
	}
}
