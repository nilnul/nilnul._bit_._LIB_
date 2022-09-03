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

namespace nilnul.bit.expr.no
{

	[Obsolete()]
	public class Call : nilnul.expr.no.Call<bool>
			, ExprI_membered, expr.AtomI

	{



		public Call(
					bit.no.OpI op
			)
				: base(op)
		{

		}

		public Call(bool a)
			: this(
				 new bit.no.Constant(a) as bit.no.OpI
				)
		{

		}

		public bit.var.Set vars
		{
			get
			{

				return new bit.var.Set();
				throw new NotImplementedException();
			}
		}

		public bit.ExprI_membered substitute(bit.VarI1 var, bit.ExprI_membered expr)
		{
			return this;
			throw new NotImplementedException();
		}

		public bit.ExprI_membered reduce()
		{
			return this;

			throw new NotImplementedException();
		}

		static public implicit operator Call(bool a)
		{
			return new Call(a);
		}

		static public Call CreateNil()
		{
			return new Call(false);
		}

		static public Call Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}

		static public Call CreateOne()
		{
			return new Call(true);
		}

		public override string ToString()
		{
			return op.eval() ? "1" : "0";
		}



	}

}
