using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;
using nilnul.tupl._seed;

namespace nilnul.bit.func
{
	public class Unary:Func
	{

		public Unary(V v, E e):base( new bit.var.tupl.Singleton(v),e)
		{

		}

		public Unary(V v, V v1):this(v, new bit.expr.VarAsExpr(v1))
		{

		}




		public V var {
			get {
				return (input as nilnul._tupl.HeadI<V>).head;

			}
}

		public E apply(E arg) {
			return this.expr.substitute(
				this.var
				,
				arg
				
			);
		}

		static public Unary CreateId(V v) {
			return new Unary(v, v);
		}

		static public Unary CreateId() {
			return CreateId(new bit.Var2());
		}



	}
}
