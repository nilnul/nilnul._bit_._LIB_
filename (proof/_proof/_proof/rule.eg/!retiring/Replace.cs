using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;
using V = nilnul.bit.VarI1;

namespace nilnul.bit._proof.rule.eg
{


	/// <summary>
	/// if the theorems contain:
	///		 x,w
	/// then:  
	///	   if  y=>z (x)  is w
	///    
	///    then y=>z (1) is theorem
	///      
	/// </summary>
	public class Replace:RuleI_blank,_rule.ResultI
	{
		/// <summary>
		/// must be ident to a theorem
		/// </summary>
		public nilnul.bit.ExprI_membered original
		{
			get
			{
				return _func.apply(_subexpr);
			}
		}

		private nilnul.bit.ExprI_membered _subexpr;

		public nilnul.bit.ExprI_membered subexpr
		{
			get { return _subexpr; }
			set { _subexpr = value; }
		}



		private nilnul.bit.func.Unary _func;

		public nilnul.bit.func.Unary func
		{
			get { return _func; }
			set { _func = value; }
		}


		public Replace(func.Unary func, E sub,  E newSub )
		{
			_func = func;
			_subexpr = sub;
			_newSub = newSub;



		}

		public Replace(func.Unary func, E sub,  V newSub ):this(
			func,sub, new expr.VarAsExpr(newSub)
		)
		{


			
		}


		/// <summary>
		/// must be ident to _subexpr
		/// </summary>
		private E _newSub;

		public E newSub
		{
			get { return _newSub; }
			set { _newSub = value; }
		}



		public E result
		{
			get
			{

				return _func.apply(newSub);

				;
			}
		}

		static public Replace Create(V x) {

			return new Replace(
				bit.func.Unary.CreateId()
				,
				nilnul.bit.expr.duo.Call.CreateEq(1,x)
				,
				x
				
			);


		}









	}
}
