using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.binary
{
	[Obsolete()]
	public partial class And_defaultCtor
		:BinaryI
	{

				
		static public bool Eval(bool x, bool y)
		{
			return x && y;
		}




		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{

			return Eval(x, y);

			throw new NotImplementedException();
		}
	}
}
