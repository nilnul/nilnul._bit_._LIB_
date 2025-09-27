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

	public class Nulary1
	:

		nilnul.bit.expr_.call_._nullary_.OpA1
		,
	nilnul.bit.expr_.call_.NularyI


	{
		public Set1 vars
		{
			get
			{
				return new Set1();

				//throw new NotImplementedException();
			}
		}

		public Nulary1(
					bool val
			)
				: base(val)
		{

		}




		static public implicit operator Nulary1(bool a)
		{
			return new Nulary1(a);
		}

		static public Nulary1 CreateNil()
		{
			return new Nulary1(false);
		}

		static public Nulary1 Create(int x)
		{
			return x == 0 ? CreateNil() : CreateOne();
		}
		static public Nulary1 Create(bool x)
		{
			return new Nulary1(x);
		}

		static public Nulary1 CreateOne()
		{
			return new Nulary1(true);
		}

		

		public ExprI2 substitute(VarI1 var, ExprI2 expr)
		{
			return this;
			throw new NotImplementedException();
		}
	}

}
