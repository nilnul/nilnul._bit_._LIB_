using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_;

namespace nilnul.bit.expr_.plain_.calc
{
	static public class _CalcX
	{
		static public bool _Reduce_assumePlainCalc(nilnul.bit.ExprI3 _form)
		{
			switch (_form)
			{
				case nilnul.bit.expr_.call_.NaryI nary:
					return nary.op.op();
					break;
				case Unary2 unary:
					return unary.op.op(
						_Reduce_assumePlainCalc(unary.arg)
					);
					break;
				case Binary1 binary:
					return 
						binary.op.op(
						_Reduce_assumePlainCalc(binary.arg)
						,
						_Reduce_assumePlainCalc(binary.arg1)
						)
					;
					break;
				default:
					throw new UnexpectedTypeException();
			}
		}


	}


}
