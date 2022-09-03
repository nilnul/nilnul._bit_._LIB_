using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr_.call_;

namespace nilnul.bit.expr_.calc
{
	[Obsolete()]
	static public class _EvalX
	{
		static public bool Eval(nilnul.bit.ExprI3 _form)
		{
			switch (_form)
			{
				case nilnul.bit.expr_.call_.NaryI nary:
					return nary.op.op();
					break;
				case Unary2 unary:
					return unary.op.op(
						Eval(unary.arg)
					);
					break;
				case Binary1 binary:
					return 
						binary.op.op(
						Eval(binary.arg)
						,
						Eval(binary.arg1)
						)
					;
					break;
				default:
					throw new UnexpectedTypeException();
			}
		}


	}


}
