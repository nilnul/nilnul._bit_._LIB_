using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.nary
{
	public class Dual<TOp>
		:
		nilnul.obj.Box1<TOp>
		,
		nilnul.bit.op_.NaryI
		,
		nilnul.bit.op.IComplement

		where TOp : bit.op_.NaryI
	{
		public Dual(TOp val) : base(val)
		{
		}


		public bool op()
		{
			return !boxed.op();
			//throw new NotImplementedException();
		}

	}
	public class Dual
		:
		Dual
		<
		nilnul.bit.op_.NaryI
			>

	{
		public Dual(NaryI val) : base(val)
		{
		}
		public Dual(bool func):this( new Nary (func) )
		{

		}
	}
}
