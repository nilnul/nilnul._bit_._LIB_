using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_
{
	public interface IVec : bit.op_.IOf {
	}
	/// <summary>
	/// of a vector
	/// </summary>
	public interface VecI
		:IVec
		,
		nilnul.bit.OpI2
		,
		nilnul.obj.op_.of_.VecI<bool>

	{

	}

	public class Vec :
		nilnul.obj.op_.of_.Vec<bool>
		,

		VecI
	{
		public Vec(int arity, Func<IEnumerable<bool>, bool> func) : base(arity, func)
		{
		}
	}

}
