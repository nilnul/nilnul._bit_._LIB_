using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	/// inverse
	public class NegPars<TOp>
		:
		nilnul.obj.Box1<TOp>
		,
		nilnul.bit.op_.BinaryI1
		,
		nilnul.bit.op.IComplement

		where TOp : bit.op_.BinaryI1
	{
		static public bool Op(TOp op, bool par, bool par1)
		{
			return op.op(!par, !par1);

		}
		public NegPars(TOp val) : base(val)
		{
		}


		public bool op(bool par, bool par1)
		{
			return Op(this.boxed, par, par1);
			//return boxed.op(!par, !par1);
			//throw new NotImplementedException();
		}

	}
	public class NegPars
		:
		NegPars
		<
		nilnul.bit.op_.BinaryI1
			>

	{
		public NegPars(BinaryI1 val) : base(val)
		{
		}
		public NegPars(Func<bool,bool,bool> func):this( new Binary(func) )
		{

		}
	}
}
