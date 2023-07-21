using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.var
{
	public class Eq :
		nilnul.obj.expr_.typed_.generi_.var.Eq<bool>
		,
		IEqualityComparer<bit.expr_.Var_sys>
	, IEqualityComparer<VarAsExpr>
		,
		IEqualityComparer<expr_.Var2>
	{

		public bool Equals(VarAsExpr x, VarAsExpr y)
		{
			return nilnul.bit.var.Eq.Singleton.Equals(x.var, y.var);

		}

		public int GetHashCode(VarAsExpr obj)
		{
			return nilnul.bit.var.Eq.Singleton.GetHashCode(obj.var);
		}



		public bool Equals(Var_sys x, Var_sys y)
		{
			return (x.ee == y.ee);
			//return object.ReferenceEquals(x.ee,y.ee);
		}

		public int GetHashCode(Var_sys obj)
		{
			return obj.ee.GetHashCode();
			//throw new NotImplementedException();
		}

		public bool Equals(Var2 x, Var2 y)
		{
			return base.Equals(x,y);
		}

		public int GetHashCode(Var2 obj)
		{
			return base.GetHashCode(obj);
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
