using nilnul.bit._expr.untyped.be.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{

	public interface ExprI_generi
		:nilnul.obj.expr_.typed_.GeneriI<bool>
		,
		bit.IExpr
	{
		//nilnul.obj.expr_.typed_.Generi<bool> sys { get; }
	}

	public class Expr_generi
		:
		nilnul.obj.expr_.typed_.Generi<bool>
		//,
		//_expr_.VarsI_sys
		,ExprI_generi
	{
		public Expr_generi(Expression val) : base(val)
		{
		}

	

		//public Generi<bool> sys => this;
	}

	/// <summary>
	/// wrapping the interface such that operator overloading would work;
	/// </summary>
	public class ExprO
		:

		nilnul.obj.Box1<ExprI_generi>
		,
		ExprI_generi
	{
		public ExprO(ExprI_generi val) : base(val)
		{
		}

		public Ee<bool> generi => boxed.generi;

		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => boxed.expr;

		public static ExprO operator &(ExprO e, ExprI_generi x) {
			return new expr_.call_.binary_.And1(e, x).ToOperand();
		}

		public static ExprO operator &(ExprO e, ParameterExpression x) {
			return new expr_.call_.binary_.And1(e, x).ToOperand();
		}


		public static ExprO operator |(ExprO e, ExprI_generi x) {
			return new ExprO(  new expr_.call_.binary_.Or1(e, x) );
		}

		public static ExprO operator |(ExprO e, ParameterExpression x) {
			return new expr_.call_.binary_.Or1(e, x).ToOperand();
		}

		public static ExprO operator ==(ExprO e, ExprI_generi x) {
			return new ExprO(  new expr_.call_.binary_.Eq_generi(e, x) );
		}
		public static ExprO operator !=(ExprO e, ExprI_generi x) {
			return new ExprO(  new expr_.call_.binary_.Ne(e, x) );
		}




	}

	static public class ExprX
	{
		static public ExprO ToOperand(this ExprI_generi x) {
			return new ExprO(x);
		}
		static public ExprO ToBitOperand(this ParameterExpression x) {
			return new bit.expr_.Var2(x).ToOperand();
		}

		static public ExprO ToOperand(this bit.expr_.Var2 x) {
			return new ExprO(x);
		}

	}
}
