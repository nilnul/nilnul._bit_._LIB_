using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary.be
{
	public class Vow
		: nilnul.obj.be.Vow4<op_.BinaryI1>
	{
		public Vow(BeI1<BinaryI1> be) : base(be)
		{
		}

		public Vow(System.Predicate<BinaryI1> predicate) : base(predicate)
		{
		}

		public Vow(Func<BinaryI1, bool> func) : base(func)
		{
		}
	}
}
