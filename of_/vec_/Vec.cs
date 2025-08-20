using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_
{
	[Obsolete(nameof(bit.of_.vec_.IScala))]
	public interface IVec : bit.op_.IOf {
	}
	/// <summary>
	/// of a vector
	/// </summary>
	///

	[Obsolete(nameof(bit.of_.vec_.IScala))]
	public interface VecI
		:IVec
		,
		bit.of_.vec_.IScala
		,
		nilnul.bit.OpI2
		,
		nilnul.obj.op_.of_.VecI<bool>

	{

	}

	public class Vec :
		nilnul.obj.of_.vec_.Scala<bool>
		,

		VecI
	{
		public Vec(int arity, Func<IEnumerable<bool>, bool> func) : base(arity, func)
		{
		}
	}

}
