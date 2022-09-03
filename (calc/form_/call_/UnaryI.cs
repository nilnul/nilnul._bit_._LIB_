using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.obj.op_._unary_.par_;

namespace nilnul.bit.form_.call_
{
	public interface UnaryI:CallI
	{
	}
	public class Unary :
		nilnul.obj.call_._unary_.OpArgA<nilnul.bit.op_.UnaryI1, nilnul.bit.FormI>
		,
		UnaryI
	{
		public Unary(op_.UnaryI1 op, FormI arg) : base(op, arg)
		{
		}

		public bool eval()
		{
			return op.op(arg.eval());
			//throw new NotImplementedException();
		}
	}
}
