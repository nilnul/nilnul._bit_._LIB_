using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.bit.VarI1;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr
{
	[Obsolete()]
	public class Substitution
	{
		private nilnul.bit.ExprI_membered _expr;

		public nilnul.bit.ExprI_membered expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		private V _var;

		public V var
		{
			get { return _var; }
			set { _var = value; }
		}


		public Substitution(V v, E e)
		{
			_var = v;
			_expr = e;
		}

		public Substitution(KeyValuePair<V, E> a)
			:this(a.Key,a.Value)
		{
			
		}



	}
}
