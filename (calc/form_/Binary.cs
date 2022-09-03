using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.obj.op_._unary_.par_;

namespace nilnul.bit.form_
{
	public interface BinaryI:FormI
	{
	}
	public class Binary :
		nilnul.obj.call_._binary_.OpArgArg1A<nilnul.bit.op_.BinaryI1, nilnul.bit.FormI, nilnul.bit.FormI>
		,
		BinaryI
	{
		public Binary(op_.BinaryI1 op, FormI arg, FormI arg1) : base(op, arg,arg1)
		{
		}

		public bool eval()
		{
			return op.op(arg.eval(),arg1.eval());
			//throw new NotImplementedException();
		}
	}
}
