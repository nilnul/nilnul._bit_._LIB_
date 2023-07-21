using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs = System.Collections.Generic.IEnumerable<nilnul.bit.expr_.Var2>;

namespace nilnul.bit.expr_.var.set
{


	public class Eq :
		nilnul.obj.set.eq_.EqDefaulted<nilnul.bit.expr_.Var_sys, nilnul.bit.expr_.var.Eq>
		,
		IEqualityComparer<nilnul.bit.expr_.var.Set4generi>
		,
		IEqualityComparer<Vs>

	{
		public bool Equals(Set4generi x, Set4generi y)
		{
			return nilnul.obj.set.eq_.EqDefaulted<nilnul.bit.expr_.Var2, nilnul.bit.expr_.var.Eq>.Singleton.Equals(x, y);
		}

		public int GetHashCode(Set4generi obj)
		{
			return nilnul.obj.set.eq_.EqDefaulted<nilnul.bit.expr_.Var2, nilnul.bit.expr_.var.Eq>.Singleton.GetHashCode(obj);

		}

		public bool Equals(Vs x, Vs y)
		{
			return nilnul.obj.set.eq_.EqDefaulted<nilnul.bit.expr_.Var2, nilnul.bit.expr_.var.Eq>.Singleton.Equals(x,y);

		}

		public int GetHashCode(Vs obj)
		{
			return nilnul.obj.set.eq_.EqDefaulted<nilnul.bit.expr_.Var2, nilnul.bit.expr_.var.Eq>.Singleton.GetHashCode(obj);
		}

		static public Eq Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq>.Unison;
			}
		}

	}
}
