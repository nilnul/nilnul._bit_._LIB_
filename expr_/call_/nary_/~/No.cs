using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul.bit.var;
using nilnul.obj._expr_;

namespace nilnul.bit.expr.call_
{

	[Obsolete(nameof(expr_.call_.No))]
	public class No
	:
	nilnul.obj.call_.no_.LiteralA<bool>
	,
		nilnul.bit.expr.call_.NoI
		,
	nilnul.bit.ExprI1


	{
		public nilnul.bit.var.Set1 vars
		{
			get
			{
				return new nilnul.bit.var.Set1();

				throw new NotImplementedException();
			}
		}

		public No(
					bool val
			)
				: base(val)
		{

		}




		static public implicit operator No(bool a)
		{
			return new No(a);
		}

		static public No CreateNil()
		{
			return new No(false);
		}

		static public No Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}

		static public No CreateOne()
		{
			return new No(true);
		}

		public ExprI1 reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI1 var, ExprI1 expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}

}
