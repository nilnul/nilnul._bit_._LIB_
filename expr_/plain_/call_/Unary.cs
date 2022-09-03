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

namespace nilnul.bit.expr_.plain_.call_
{


	public class Unary
		:
		nilnul.obj.call_._unary_.OpArgA<nilnul.bit.op_.UnaryI1, nilnul.bit.expr_.PlainI>
		,
		UnaryI

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

		static public Unary CreateNeg(bit.Var2 x)
		{
			return new Unary(bit.op_.unary_.Not1.Singleton, x);

		}

		static public Unary CreateNeg(bit.VarI1 x)
		{
			return new Unary(bit.op_.unary_.Not1.Singleton, x);

		}

		static public Unary CreateNeg(bit.expr_.PlainI x)
		{
			return new Unary(bit.op_.unary_.Not1.Singleton, x);

		}

		

		public PlainI substitute(VarI1 var, PlainI expr)
		{
			return new Unary(
				this.op,
				(arg).substitute(var, expr)

			);
			//throw new NotImplementedException();
		}

		public Unary(
			bit.op_.UnaryI1 op,
				bit.expr_.PlainI x
		)
			: base(op, x)
		{

		}
		public Unary(
			bit.op_.UnaryI1 op,

			bit.VarI1 x

			)
			: this(op,
				new nilnul.bit.expr_.plain_.Var(x)
			)
		{

		}


		public Unary(
			bit.op_.UnaryI1 op,

			bit.Var2 x

			)
			: this(op,
				new nilnul.bit.expr_.plain_.Var(x)
			)
		{

		}
		public override string ToString()
		{
			if (arg is BinaryI)
			{
				return $"{this.op}({arg})";
			}
			return this.op.ToString() + arg.ToString();
		}

	}

}
