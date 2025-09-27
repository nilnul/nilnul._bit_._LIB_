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

namespace nilnul.bit.expr_.call_
{

	public class Nary
	:

		nilnul.bit.expr_.call_._nullary_.OpA1
		,
	nilnul.bit.expr_.call_.NaryI


	{
		public nilnul.bit.var.Set2 vars
		{
			get
			{
				return new nilnul.bit.var.Set2();

				//throw new NotImplementedException();
			}
		}

		public Nary(
					bool val
			)
				: base(val)
		{

		}




		static public implicit operator Nary(bool a)
		{
			return new Nary(a);
		}

		static public Nary CreateNil()
		{
			return new Nary(false);
		}

		static public Nary Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}
		static public Nary Create(bool x)
		{
			return new Nary(x);
		}

		static public Nary CreateOne()
		{
			return new Nary(true);
		}



		public ExprI3 substitute(VarI1 var, ExprI3 expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}

}
