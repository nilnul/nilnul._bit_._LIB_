using nilnul.bit._expr.untyped.be.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	

	/// <summary>
	/// the basis of an expr, which is recursively defined.
	/// </summary>
	///
	//[Obsolete(naemof(bit.expr_.vari))]
	public class Var2 :

		nilnul.obj.expr_.typed_.generi_.Var<bool>
		,
		nilnul.bit.expr_.IVar
		,
		IEquatable<Var2>
		,
		bit.ExprI_generi
		

	{

		public Var2(ParameterExpression val) : base(val)
		{

		}
		public Var2():this(
			Expression.Parameter(typeof(bool) )
		)
		{

		}
		public Var2(string s):this(
			Expression.Parameter(typeof(bool), s)
		)
		{

		}

		public bool Equals(Var2 other)
		{
			return obj.expr_.var.Eq.Singleton.Equals(this.sys, other.sys);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return obj. expr_.var.Eq.Singleton.GetHashCode(this.sys);
		}

		static public  bool operator ==(
			Var2 x,
			Var2 y

			) {
			return obj. expr_.var.Eq.Singleton.Equals(x.sys, y.sys);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var2 var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}
		static public  bool operator !=(
			Var2 x,
			Var2 y

			) {
			return !(x== y);

		}

	}
}
