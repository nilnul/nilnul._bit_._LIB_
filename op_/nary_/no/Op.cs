using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.no
{

	public class Constant:obj.no.Constant<bool>, OpI
	{

		public Constant(bool val):base(val)
		{

		}

		static public implicit operator Constant(bool val) {
			return new Constant(val);
		}

		static public implicit operator bool(Constant op) {
			return op.val;
		}


	}


	public class Op:obj.no.Op<bool>, OpI
	{

		public Op(Func<bool > func):base(func)
		{

		}



	}

	public interface OpI
		:nilnul.no.OpI<bool>, bit.OpI,nilnul.obj.no.OpI<bool>
	{


	}
}
