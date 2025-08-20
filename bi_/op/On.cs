using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.duo.op
{
	public partial class On:bit.op.BinaryI
		,
		OpI
	{

		static public readonly On Singleton = SingletonByDefault<On>.Instance;
		[Obsolete()]
		public On()
		{

		}

		static public bool Eval(bool x, bool y) {
			return true;
		}

		public bool exec(bool x, bool y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);

			throw new NotImplementedException();
		}
	}
}
