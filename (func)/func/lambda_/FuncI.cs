using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.lambda_
{
	public class Func :
		nilnul.Box1<nilnul.bit.FuncI2>
		,
		LambdaI
	{
		public Func(FuncI2 val) : base(val)
		{
		}

		public FuncI2 eval()
		{
			return boxed;
			throw new NotImplementedException();
		}
	}
}
