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
	public class Replace_resultIff:RuleI_blank,_rule.ResultI
	{


		/// <summary>
		/// this is from the theorems set. if the theorems set contains no such expr of this class, one such type of expr should be derived from that theorems.
		/// </summary>
		/// <remarks>
		///  this is theorem
		/// </remarks>

		private nilnul.bit.expr.duo.op.iff.Apply _iff;

		public nilnul.bit.expr.duo.op.iff.Apply iff
		{
			get { return _iff; }
			set { _iff = value; }
		}



		public nilnul.bit.ExprI_membered subexpr
		{
			get { return _iff.arg; }
		}


		public E newSub
		{
			get { return _iff.arg1; }
		}



		/// <summary>
		/// the var is meta var for expr.
		/// </summary>
		private nilnul.bit.func.Unary _func;

		public nilnul.bit.func.Unary func
		{
			get { return _func; }
			set { _func = value; }
		}


		public Replace_resultIff(func.Unary func, bit.expr.duo.op.iff.Apply replacingExprs )
		{
			_func = func;
			_iff = replacingExprs;


		}

		/// <summary>
		/// must be ident to a theorem
		/// </summary>
		public nilnul.bit.ExprI_membered original
		{
			get
			{
				return _func.apply(subexpr);
			}
		}

		


		public E replaced
		{
			get
			{

				return _func.apply(newSub);

				;
			}
		}

		/// <summary>
		/// a theorem. 
		/// </summary>
		public  E result {
			get {
				return new  bit.expr.duo.op.iff.Apply(original,result);
			}
		}



	









	}
}
