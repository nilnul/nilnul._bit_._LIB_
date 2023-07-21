using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E= nilnul.bit.ExprI1;

namespace nilnul.bit.expr
{
	/// <summary>
	/// same
	/// </summary>
	/// 
	[Obsolete()]
	public class Eq1 : IEqualityComparer<E>
	{

		static public readonly Eq1 Singleton = Singleton<Eq1>.Instance;

		public bool Equals(E x, E y)
		{
			if (x is expr_.VarAsExpr )
			{
				if (y is expr_.VarAsExpr)
				{
					return (x as expr_.VarAsExpr).var == (y as expr_.VarAsExpr).var;
				}
				return false;
			}
			else if (x is expr_.call_.No)
			{
				if (y is expr_.call_.No)
				{
					var xCall = x as expr_.call_.No;
					var yCall = y as expr_.call_.No;
					return nilnul.bit.Constant.Eq.Singleton.Equals( xCall.op , yCall.op) ;  
				}
				else
				{
					return false;
				}
			}

			else if (x is expr.call_.Mono)
			{
				if (y is expr.call_.Mono)
				{
					var xCall = x as expr.call_.Mono;
					var yCall = y as expr.call_.Mono;
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
			throw new UnexpectedReachException();

		}

		public int GetHashCode(E obj)
		{
			return 0;
		}
	}
}
