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

namespace nilnul.bit.expr
{
	[Obsolete()]
	public class VarAsExpr
		
		:nilnul.expr.VarAsExpr<nilnul.bit.VarI1>
		,
		nilnul.bit.expr.AtomI
		,
		
		nilnul._expr.VarsI<nilnul.bit.var.Set>
		,nilnul.bit.ExprI_membered


	{
		public VarAsExpr(bit.VarI1 x)
			:base(x)
		{

		}



		public nilnul.bit.var.Set vars
		{
			get
			{
				return new bit.var.Set() { this.var as bit.VarI1};
				throw new NotImplementedException();
			}
		}

		Set_ofVarI VarsI<Set_ofVarI>.vars
		{
			get
			{
				return new Set_ofVarI(this.var);
				throw new NotImplementedException();
			}
		}

		public nilnul._op.OpI_generic op
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		static public implicit operator VarAsExpr(bit.Var2 x) {	//note VarI1 as an interface will be not applicable in a type conversion.

			return new VarAsExpr(x);

		}

		

		

		
	

		ExprI_membered<bool> nilnul._expr.ReduceI<ExprI_membered<bool>>.reduce()
		{
			return reduce();
			throw new NotImplementedException();
		}

	

		public ExprI_membered reduce()
		{
				return this;
		throw new NotImplementedException();
		}

		public ExprI_membered substitute(VarI1 var, ExprI_membered expr)
		{
			if (this.var == var)
			{
				return expr;
			}
			else
			{
				return this;
			}

			throw new NotImplementedException();


			throw new NotImplementedException();
		}

		public ExprI_membered<bool> substitute<V>(VarI1<V> var, ExprI_membered<V> expr)
		{
			
			if (this.var == var)
			{
				return expr as ExprI_membered<bool>;
			}
			else
			{
				return this;
			}

			throw new NotImplementedException();

			throw new NotImplementedException();
		}
	}
}
