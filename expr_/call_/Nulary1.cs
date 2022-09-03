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
using System.Linq.Expressions;
using nilnul.bit._expr.untyped.be.vow;

namespace nilnul.bit.expr_.call_
{

	public class Nary_sys
	:

		nilnul.obj.expr_.call_.NaryA< bit.op_.NaryI>

		,
		nilnul.bit.ExprI_sys


	{
		public nilnul.bit.var.Set2 vars
		{
			get
			{
				return new nilnul.bit.var.Set2();

				//throw new NotImplementedException();
			}
		}

		public Ee sys => new Ee(
			Expression.Constant(this.op.op())
		);

		public Nary_sys(
					bool val
			)
				: base(new bit.op_.Nary(val) )
		{

		}




		static public implicit operator Nary_sys(bool a)
		{
			return new Nary_sys(a);
		}

		static public Nary_sys CreateNil()
		{
			return new Nary_sys(false);
		}

		static public Nary_sys Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}
		static public Nary_sys Create(bool x)
		{
			return new Nary_sys(x);
		}

		static public Nary_sys CreateOne()
		{
			return new Nary_sys(true);
		}

	}

}
