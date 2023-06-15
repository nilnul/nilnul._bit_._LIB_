using nilnul.bit._expr.untyped.be.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	static public class _VarX
	{
		static public bool Is(ParameterExpression x) {
			return x.Type == typeof(bool);
		}

		static public ParameterExpression Of() {
			return Expression.Parameter(typeof(bool));
		}
		static public ParameterExpression Of(string name) {
			return Expression.Parameter(typeof(bool),name);
		}


	}

	/// <summary>
	/// the basis of an expr, which is recursively defined.
	/// </summary>
	///
	[Obsolete(nameof(bit.expr_.Var2))]
	public class Var_sys : _var.sys.be.vow.Ee
		,
		nilnul.bit.expr_.IVar
		,
		IEquatable<Var_sys>
		,
		ExprI_sys
		

	{
		public Ee sys => new Ee(this.ee);

		public Var_sys(ParameterExpression val) : base(val)
		{

		}
		public Var_sys():this(
			Expression.Parameter(typeof(bool) )
		)
		{

		}
		public Var_sys(string s):this(
			Expression.Parameter(typeof(bool), s)
		)
		{

		}

		public bool Equals(Var_sys other)
		{
			return expr_.var.Eq.Singleton.Equals(this, other);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return expr_.var.Eq.Singleton.GetHashCode(this);
		}

		static public  bool operator ==(
			Var_sys x,
			Var_sys y

			) {
			return expr_.var.Eq.Singleton.Equals(x, y);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var_sys var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}
		static public  bool operator !=(
			Var_sys x,
			Var_sys y

			) {
			return !(x== y);

		}

	}
}
