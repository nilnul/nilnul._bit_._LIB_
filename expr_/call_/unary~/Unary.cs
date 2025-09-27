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
	public class Unary2
		:
		nilnul.obj.call_.Unary<nilnul.bit.op_.UnaryI1, nilnul.bit.ExprI3>
		,
		nilnul.bit.expr_.call_.UnaryI1

	{
		public nilnul.bit.var.Set2 vars
		{
			get
			{
				var r = new bit.var.Set2();
				r.UnionWith(
						(arg).vars

					);

				return r;
				//throw new NotImplementedException();
			}
		}

		static public Unary2 CreateNeg(bit.Var2 x)
		{
			return new Unary2(bit.op_.unary_.Not1.Singleton, x);

		}

		static public Unary2 CreateNeg(bit.VarI1 x)
		{
			return new Unary2(bit.op_.unary_.Not1.Singleton, x);

		}

		static public Unary2 CreateNeg(bit.ExprI3 x)
		{
			return new Unary2(bit.op_.unary_.Not1.Singleton, x);

		}

		

		public ExprI3 substitute(VarI1 var, ExprI3 expr)
		{
			return new Unary2(
				this.op,
				(arg).substitute(var, expr)

			);
			//throw new NotImplementedException();
		}

		public Unary2(
			bit.op_.UnaryI1 op,
				bit.ExprI3 x
		)
			: base(op, x)
		{

		}
		public Unary2(
			bit.op_.UnaryI1 op,

			bit.VarI1 x

			)
			: this(op,
				new nilnul.bit.expr_.Var1(x)
			)
		{

		}


		public Unary2(
			bit.op_.UnaryI1 op,

			bit.Var2 x

			)
			: this(op,
				new nilnul.bit.expr_.Var1(x)
			)
		{

		}

		public override string ToString()
		{
			return $"{op}{arg}";
		}
	}

}
