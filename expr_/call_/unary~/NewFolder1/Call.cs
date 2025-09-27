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

namespace nilnul.bit.expr
{
	[Obsolete()]
	public class CallX
	{

		static public Call CreateNeg(bit.VarI1 x)
		{
			return new Call(bit.op.Not.Singleton, x);

		}
		static public Call CreateNeg(bit.ExprI_membered x)
		{
			return new Call(bit.op.Not.Singleton, x);

		}

	}
	[Obsolete()]
	public class Call : nilnul.expr.Call<bit.OpI1, bool, bool, bit.ExprI_membered>
		, bit.ExprI_membered
		,bit.expr.NoMonoCallI
	{

		public override string ToString()
		{
			var argStr = arg.ToString();

			if (arg is AtomI || arg is Call)
			{

			}
			else
			{ argStr=$"({argStr})";

			}

			return $"{op}{argStr}";


        }
		static public Call CreateNeg(bit.Var2 x)
		{
			return new Call(bit.op.Not.Singleton, x);

		}

		static public Call CreateNeg(bit.VarI1 x)
		{
			return new Call(bit.op.Not.Singleton, x);

		}

		static public Call CreateNeg(bit.ExprI_membered x)
		{
			return new Call(bit.op.Not.Singleton, x);

		}


		public Call(
			bit.OpI1 op,
				bit.ExprI_membered x
		)
			: base(op, x)
		{

		}
		public Call(
			bit.OpI1 op,

			bit.VarI1 x

			)
			: this(op,
				new VarAsExpr(x)
			)
		{

		}


		public Call(
			bit.OpI1 op,

			bit.Var2 x

			)
			: this(op,
				new VarAsExpr(x)
			)
		{

		}

	 	public new bit.var.Set vars
		{
			get
			{

				var r = new bit.var.Set();
				r.UnionWith(
						(arg as bit._expr.VarsI).vars

					);

				return r;

				throw new NotImplementedException();
			}
		}

		public bit.ExprI_membered substitute(bit.Var2 var, bit.ExprI_membered expr)
		{
			return new Call(
				this.op,
				(arg as bit._expr.SubstituteI).substitute(var, expr)

			);
			throw new NotImplementedException();
		}

		public bit.ExprI_membered reduce()
		{
			var argReduced = (arg as  _expr.ReduceI).reduce();

			if (argReduced is no.Call)
			{
				return new no.Call(
					op.eval(

						(argReduced as no.Call).eval()

					)

				);
			}
			else
			{
				return new Call(
					op
					,
					argReduced
				);
			}

			throw new NotImplementedException();
		}

		

		public  ExprI_membered substitute(VarI1 var, ExprI_membered expr)
		{

			return new Call(
				this.op,
				(arg as bit._expr.SubstituteI).substitute(var, expr)

			);
			throw new NotImplementedException();

		}
	}

}
