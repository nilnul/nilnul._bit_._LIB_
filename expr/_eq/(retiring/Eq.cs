using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E= nilnul.bit.ExprI_membered;

namespace nilnul.bit.expr
{
	[Obsolete(nameof(Eq1))]
	public class Eq : IEqualityComparer<E>
	{

		static public readonly Eq Singleton = SingletonByDefault<Eq>.Instance;

		public bool Equals(E x, E y)
		{
			if (x is VarAsExpr )
			{
				if (y is VarAsExpr)
				{
					return (x as VarAsExpr).var == (y as VarAsExpr).var;
				}
				return false;
			}
			else if (x is Call)
			{
				if (y is Call)
				{
					var xCall = x as Call;
					var yCall = y as Call;
					return xCall.op == yCall.op && Equals(xCall.arg, yCall.arg);  
				}
				else
				{
					return false;
				}
			}
			else if (x is duo.Call)
			{
				if (y is duo.Call)
				{
					var xCall = x as duo.Call;
					var yCall = y as duo.Call;
					return xCall.op == yCall.op && Equals(xCall.arg, yCall.arg) && Equals(xCall.arg1,xCall.arg1);  

				}
				return false;
			}
			else 
			{
				throw new UnexpectedTypeException();

			}

			throw new NotImplementedException();
		}

		public int GetHashCode(E obj)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
}
