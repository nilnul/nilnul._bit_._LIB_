using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.logic.func
{
	public partial class BinaryFuncCall<OpT1,OpT2,T1,T2>
		where T1:OpT1
		where T2:OpT2
	{
		BinaryFuncI<OpT1, OpT2> func;
		T1 left;
		T2 right;

		public BinaryFuncCall(BinaryFuncI<OpT1,OpT2> func,T1 left,T2 right)
		{

			this.func = func;
			this.left = left;
			this.right = right;

		}
					
	}
}
