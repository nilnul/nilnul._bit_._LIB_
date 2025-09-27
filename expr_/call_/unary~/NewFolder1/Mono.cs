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

namespace nilnul.bit.expr.call_
{


	public class Mono
		:
		nilnul.obj.call_.Mono<nilnul.bit.OpI1, nilnul.bit.ExprI1>
		,
		nilnul.bit.ExprI1

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
				throw new NotImplementedException();
			}
		}

		static public Mono CreateNeg(bit.Var2 x)
		{
			return new Mono(bit.op.Not.Singleton, x);

		}

		static public Mono CreateNeg(bit.VarI1 x)
		{
			return new Mono(bit.op.Not.Singleton, x);

		}

		static public Mono CreateNeg(bit.ExprI1 x)
		{
			return new Mono(bit.op.Not.Singleton, x);

		}

		public ExprI1 reduce()
		{
			var argReduced = arg.reduce();

			if (argReduced is  nilnul.bit.expr.call_.No)
			{
				//var callNo = argReduced as nilnul.bit.expr.call_.No;

				return new call_.No(
					op.eval(

						(argReduced as nilnul.bit.expr.call_.No).eval()

					)

				);
			}
			else
			{
				return new Mono(
					op
					,
					argReduced
				);
			}

			throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI1 var, ExprI1 expr)
		{
			return new Mono(
				this.op,
				(arg).substitute(var, expr)

			);
			//throw new NotImplementedException();
		}

		public Mono(
			bit.OpI1 op,
				bit.ExprI1 x
		)
			: base(op, x)
		{

		}
		public Mono(
			bit.OpI1 op,

			bit.VarI1 x

			)
			: this(op,
				new nilnul.bit.expr_.VarAsExpr(x)
			)
		{

		}


		public Mono(
			bit.OpI1 op,

			bit.Var2 x

			)
			: this(op,
				new nilnul.bit.expr_.VarAsExpr(x)
			)
		{

		}


	}

}
