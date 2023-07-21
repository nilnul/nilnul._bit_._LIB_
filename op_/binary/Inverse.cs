using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary
{
	/// <summary>
	/// like De Morgan rule, we neg the pars and the rets.
	/// eg:
	///   the morgan of And would be Or
	///   Or(x,y) = !And(!x,!y)
	///   
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	/// dual
	/// contrapose
	/// inverse.
	public class Morgan<TOp>
		:
		nilnul.obj.Box1<TOp>
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.bit.op.IComplement

		where TOp : bit.op_.BinaryI1
	{
		public Morgan(TOp val) : base(val)
		{
		}

		public bool op(bool par, bool par1)
		{
			return !NegPars.Op(boxed, par, par1);
			//throw new NotImplementedException();
		}

	}
	public class Morgan
		:
		Morgan
		<
		nilnul.bit.op_.BinaryI1
			>

	{
		public Morgan(BinaryI1 val) : base(val)
		{
		}
		public Morgan(Func<bool,bool,bool> func):this( new Binary(func) )
		{

		}
	}
}
