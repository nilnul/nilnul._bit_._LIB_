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
using nilnul.obj.expr.be_.typed_.generi.vow;

namespace nilnul.bit.expr_.call_
{

	public class Nary4generi
	:

		nilnul.obj.expr_.call_.NaryA< bit.op_.NaryI>

		,
		nilnul.bit.expr_.CapsuleI



	{
		public nilnul.bit.expr_.var.Set4generi vars
		{
			get
			{
				return new nilnul.bit.expr_.var.Set4generi();

				//throw new NotImplementedException();
			}
		}

		public Ee sys => new Ee(
			Expression.Constant(this.op.op())
		);
		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => new obj._expr.expr0lamda.be_.nonlamda.vow.Ee(
			Expression.Constant(this.op.op())
		);

		public Ee<bool> generi => new Ee<bool>(
			this
		);


		public Nary4generi(
					bool val
			)
				: base(new bit.op_.Nary(val) )
		{

		}




		static public implicit operator Nary4generi(bool a)
		{
			return new Nary4generi(a);
		}

		static public Nary4generi CreateNil()
		{
			return new Nary4generi(false);
		}

		static public Nary4generi Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}
		static public Nary4generi Create(bool x)
		{
			return new Nary4generi(x);
		}

		static public Nary4generi CreateOne()
		{
			return new Nary4generi(true);
		}

	}

}
