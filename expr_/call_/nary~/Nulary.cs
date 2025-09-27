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

	[Obsolete()]
	public class Nulary
	:

		nilnul.bit.expr_.call_._nullary_.OpA
		,
	nilnul.bit.expr_.CallI


	{
		public Set1 vars
		{
			get
			{
				return new Set1();

				throw new NotImplementedException();
			}
		}

		public Nulary(
					bool val
			)
				: base(val)
		{

		}




		static public implicit operator Nulary(bool a)
		{
			return new Nulary(a);
		}

		static public Nulary CreateNil()
		{
			return new Nulary(false);
		}

		static public Nulary Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}
		static public Nulary Create(bool x)
		{
			return new Nulary(x);
		}

		static public Nulary CreateOne()
		{
			return new Nulary(true);
		}

		

		public ExprI2 substitute(VarI1 var, ExprI2 expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}

}
