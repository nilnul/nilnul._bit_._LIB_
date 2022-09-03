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
	/// complement
	/// inverse
	public class NegRet<TOp>
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
			return !op.op(par, par1);
			//throw new NotImplementedException();
		}
		public NegRet(TOp val) : base(val)
		{
		}


		public bool op(bool par, bool par1)
		{
			return !boxed.op(par, par1);
			//throw new NotImplementedException();
		}


	}
	public class NegRet
		:
		NegRet
		<
		nilnul.bit.op_.BinaryI1
			>

	{
		public NegRet(BinaryI1 val) : base(val)
		{
		}
		public NegRet(Func<bool,bool,bool> func):this( new Binary(func) )
		{

		}
	}
}
