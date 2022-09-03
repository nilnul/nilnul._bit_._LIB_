using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain_.call_.arithm
{
	[Obsolete()]
	static public class _ReduceX
	{
		static public nilnul.bit.FormI _Reduce(nilnul.bit.expr_.PlainI _form)
		{
			switch (_form)
			{
				case NaryI nary:
					return new nilnul.bit.form_.Nary(nary.op);
					break;
				case UnaryI unary:
					return new nilnul.bit.form_.Unary(unary.op,
						_Reduce(unary.arg)
					);
					break;
				case BinaryI binary:
					return new nilnul.bit.form_.Binary(
						binary.op,
						_Reduce(binary.arg)
						,
						_Reduce(binary.arg1)
					);
					break;
				default:
					throw new UnexpectedTypeException();
			}
		}

		static public nilnul.bit.FormI Reduce(nilnul.bit.expr_.plain_.call_.Form expr)
		{
			return _Reduce(expr.en);
		}

		static public bool Eval(nilnul.bit.expr_.plain_.call_.Form expr)
		{
			return Reduce(expr).eval();
		}
		static public bool _Eval(nilnul.bit.expr_.PlainI _form)
		{
			return _Reduce(_form).eval();
		}

	}


}
