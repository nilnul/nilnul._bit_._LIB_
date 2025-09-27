using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.var;
using nilnul._op;
using nilnul.bit.var;

namespace nilnul.bit.expr_
{
	/// <summary>
	/// this is the base clause of the three recursion clauses for the definition of Expr
	/// </summary>
	/// 
	[Obsolete()]
	public class VarAsExpr
		
		:nilnul.obj.expr_.VarAsExpr<nilnul.bit.VarI1>
		
		, 
		nilnul.bit.ExprI1
		
		


	{
		public VarAsExpr(bit.VarI1 x)
			:base(x)
		{

		}

		public Set1 vars
		{
			get
			{
				return new Set1(this.var);
				//throw new NotImplementedException();
			}
		}

		public ExprI1 reduce()
		{
			return this;
			//throw new NotImplementedException();
		}

		public ExprI1 substitute(VarI1 var, ExprI1 expr)
		{
			if (var==this.var)
			{
				return expr;
			}
			return this;
			//throw new NotImplementedException();
		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		static public implicit operator VarAsExpr(bit.Var2 x) {	//note VarI1 as an interface will be not applicable in a type conversion.

			return new VarAsExpr(x);

		}

		public override string ToString()
		{
			return var.ToString();
		}






	}
}
