using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func_.tauto_.unary.apply
{
	/// <summary>
	/// also known as 代入规则（Substitute Rule）.
	/// 
	/// </summary>
	/// <remarks>
	///  ( a => a||b  iif b|| a  )  as a func is expression tauto in that a||b iif b||a is tauto.
	///  So, 
	///   ( a => a||b  iif b|| a  ) (A) is 代入规则(substitue rule).  this can evaluate to an expression which is still a tauto.
	///   
	/// 
	/// note: by this, we eliminate the necessity of using ExprVar such as A, B.
	/// </remarks>
	public class Call

	{
		private UnaryI _unary;

		public UnaryI unary
		{
			get { return _unary; }
			set { _unary = value; }
		}

		private nilnul.bit.expr_.PlainI _plain;

		public nilnul.bit.expr_.PlainI plain
		{
			get { return _plain; }
			set { _plain = value; }
		}

		public Call(UnaryI unary, nilnul.bit.expr_.PlainI plain)
		{
			_unary = unary;
			_plain = plain;
		}

		/// <summary>
		/// we get one tauto expr.
		/// </summary>
		/// <returns></returns>
		public nilnul.bit.expr_.PlainI _eval() {
			return nilnul.bit.func.convert_._ApplyX.Op(_unary.unary.en.tauto.en, _plain).expr;
		}

		public nilnul.bit.expr_.plain_.Tauto eval() {
			return new nilnul.bit.expr_.plain_.Tauto(_eval());
		}


		public override string ToString()
		{
			return $@"({_unary})({_plain})";
		}
	}
}
