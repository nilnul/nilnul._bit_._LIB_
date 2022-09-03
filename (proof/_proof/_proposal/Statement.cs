using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr;

namespace nilnul.bit._theorem._proposal
{
	public class Statement : StatementI
	{
		public Statement(ExprI1 presumption, ExprI1 conclusion )
		{
			_antecedent = presumption;
			_consequent = conclusion;
		}



		private ExprI1 _consequent;
		public ExprI1 consequent
		{
			set {
				_consequent = value;
			}
			get
			{
				return _consequent;
				throw new NotImplementedException();
			}
		}

		private ExprI1 _antecedent;
		public ExprI1 antecedent
		{
			set {
				_antecedent = value;
			}
			get
			{
				return _antecedent;
				throw new NotImplementedException();
			}
		}

	
	}
}
