using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.lambda_
{
	public class Compo : 
		nilnul._call_.arg_.arg1_.ArgsSameType<LambdaI>
		,
		LambdaI
	{
		

		public Compo(LambdaI func, LambdaI arg) : base(func, arg)
		{
		}

		public FuncI2 eval()
		{
			return nilnul.bit.func.combine_._CompoX.Op(
				arg.eval()
				,
				arg1.eval()
			);
			//throw new NotImplementedException();
		}
	}
}
