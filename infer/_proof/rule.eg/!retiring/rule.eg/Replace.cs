using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI_membered;

namespace nilnul.bit.sys._proof.rule.eg
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











	}
}
