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

namespace nilnul.bit.expr_.plain_.call_
{

	public class Nary
	:

		nilnul.bit.expr_.call_._nary_.OpA
		,
	NaryI


	{
		public Set2 vars
		{
			get
			{
				return new Set2();

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

		

		public PlainI substitute(VarI1 var, PlainI expr)
		{
			return this;
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return this.op.ToString();
		}
	}

}
