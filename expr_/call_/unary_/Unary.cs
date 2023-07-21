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
using nilnul._expr;
using nilnul.bit.var;
using nilnul.obj._expr_;

namespace nilnul.bit.expr_.call_
{

	[Obsolete()]
	public class Unary1
		:
		nilnul.obj.call_.Mono<nilnul.bit.op_.UnaryI, nilnul.bit.ExprI2>
		,
		nilnul.bit.expr_.call_.UnaryI

	{
		public nilnul.bit.var.Set1 vars
		{
			get
			{
				var r = new bit.var.Set1();
				r.UnionWith(
						(arg).vars

					);

				return r;
				//throw new NotImplementedException();
			}
		}

		static public Unary1 CreateNeg(bit.Var2 x)
		{
			return new Unary1(bit.op_.unary_.Not.Singleton, x);

		}

		static public Unary1 CreateNeg(bit.VarI1 x)
		{
			return new Unary1(bit.op_.unary_.Not.Singleton, x);

		}

		static public Unary1 CreateNeg(bit.ExprI2 x)
		{
			return new Unary1(bit.op_.unary_.Not.Singleton, x);

		}

		

		public ExprI2 substitute(VarI1 var, ExprI2 expr)
		{
			return new Unary1(
				this.op,
				(arg).substitute(var, expr)

			);
			//throw new NotImplementedException();
		}

		public Unary1(
			bit.op_.UnaryI op,
				bit.ExprI2 x
		)
			: base(op, x)
		{

		}
		public Unary1(
			bit.op_.UnaryI op,

			bit.VarI1 x

			)
			: this(op,
				new nilnul.bit.expr_.Var(x)
			)
		{

		}


		public Unary1(
			bit.op_.UnaryI op,

			bit.Var2 x

			)
			: this(op,
				new nilnul.bit.expr_.Var(x)
			)
		{

		}


	}

}
