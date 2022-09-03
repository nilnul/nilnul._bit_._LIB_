using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using VSet = nilnul.bit.var.stati.Set;


namespace nilnul.bit.expr.stati.mono
{

	public class CallX
	{

		static public Call CreateNeg(bit.var.stati.Stati x)
		{
			return new Call(bit.mono.op.Not.Singleton, x);

		}
		static public Call CreateNeg(bit.expr.stati.StatiI x)
		{
			return new Call(bit.mono.op.Not.Singleton, x);

		}

	}

	public class Call : nilnul.obj.expr.stati.mono.Call<bit.mono.OpI, bool, bool, bit.expr.stati.StatiI>
		, StatiI
	{

		public override string ToString()
		{
			return $"{op}({arg})";
        }
		static public Call CreateNeg(bit.var.stati.Stati x)
		{
			return new Call(bit.mono.op.Not.Singleton, x);

		}
		static public Call CreateNeg(bit.expr.stati.StatiI x)
		{
			return new Call(bit.mono.op.Not.Singleton, x);

		}


		public Call(
			bit.mono.OpI op,
				bit.expr.stati.StatiI x
		)
			: base(op, x)
		{

		}

		public Call(
			bit.mono.OpI op,

			bit.var.stati.Stati x

			)
			: this(op,
				new VarAsExpr(x)
			)
		{

		}

		VSet _stati.VarsI.vars
		{
			get
			{

				var r = new VSet();
				r.UnionWith(
						(arg as bit.expr.stati._stati.VarsI).vars

					);

				return r;

				throw new NotImplementedException();
			}
		}

		public StatiI substitute(Stati var, StatiI expr)
		{
			return new Call(
				this.op,
				(arg as bit.expr.stati._stati.SubstituteI).substitute(var, expr)

		);
			throw new NotImplementedException();
		}

		StatiI ReduceI<StatiI>.reduce()
		{
			var argReduced = (arg as ReduceI).reduce();

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
	}

}
