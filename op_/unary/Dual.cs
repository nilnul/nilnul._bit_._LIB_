using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.unary
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	/// complement
	/// negReturn
	/// 
	public class Complement<TOp>
		:
		nilnul.obj.Box1<TOp>
		,
		nilnul.bit.op_.UnaryI1
		,
		nilnul.bit.op.IComplement

		where TOp : bit.op_.UnaryI1
	{
		public Complement(TOp val) : base(val)
		{
		}


		public bool op(bool par)
		{
			return !boxed.op(par);
			//throw new NotImplementedException();
		}

	}
	public class Complement
		:
		Complement
		<
		nilnul.bit.op_.UnaryI1
			>

	{
		public Complement(UnaryI1 val) : base(val)
		{
		}
		public Complement(Func<bool,bool> func):this( new Unary(func) )
		{

		}
	}
}
