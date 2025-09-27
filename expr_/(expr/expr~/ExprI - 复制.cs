using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul._op;
using nilnul.bit._expr;
using nilnul.bit.var;
using nilnul.var;

namespace nilnul.bit
{


	
	[Obsolete(nameof(ExprI1))]

	public interface ExprI_membered
		:nilnul.ExprI_membered<bool>
		,nilnul.bit._expr.ReduceI
		,nilnul.bit._expr.SubstituteI
		,
		nilnul.bit._expr.VarsI
	{

	}

	[Obsolete()]
	public abstract class ExprA : ExprI_membered
	{
		

		public abstract nilnul.bit.var.Set vars
		{
			get
			;
		}

		Set_ofVarI VarsI<Set_ofVarI>.vars
		{
			get
			{
				return new Set_ofVarI(vars.Cast<nilnul.VarI1>());
				throw new NotImplementedException();
			}
		}

		public abstract nilnul._op.OpI_generic op
		{
			get
			;
		}

		public abstract ExprI_membered substitute(VarI1 var, ExprI_membered expr)
		;

		public ExprI_membered<bool> substitute<V>(VarI1<V> var, ExprI_membered<V> expr)
		{
			return substitute(var,expr);
			throw new NotImplementedException();
		}

		public abstract ExprI_membered reduce()
		;

		ExprI_membered<bool> ReduceI<ExprI_membered<bool>>.reduce()
		{
			return reduce();
			throw new NotImplementedException();
		}
	}




}
