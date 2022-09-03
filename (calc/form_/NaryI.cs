using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.op_;
using nilnul.obj.op_._unary_.par_;

namespace nilnul.bit.form_
{
	public interface NaryI:nilnul.bit.FormI
	{
	}
	public class Nary :
		nilnul.obj._call_.OpA1<op_.NaryI>
		,
		NaryI
	{
		public Nary(op_.NaryI op) : base(op)
		{
		}

		public bool eval()
		{
			return op.op();
			//throw new NotImplementedException();
		}
	}
}
