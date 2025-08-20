using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.of_
{
	/// <summary>
	/// <see cref="bit.IVec"/> to bool;
	/// </summary>
	/// <remarks>
	/// in designing a circuit, we need to know in advance how many input wires are to be fixed;
	/// for a str of signals when the arity is not known, we need the signals over time;<see cref="IStr"/>
	/// </remarks>
	/// <see cref="bit.scala"/>

	public interface IVec : bit.IOf {
	}

	[Obsolete(nameof(bit.of_.vec_.IScala))]
	public interface VecI
		:
		IVec
		//,
		//nilnul.bit.IOf
		,
		nilnul.obj.of_.vec_.ScalaI<bool>

	{

	}

	[Obsolete(nameof(Scala))]
	public class Vec :
		nilnul.obj.of_.vec_.Scala<bool>
		,

		ScalaI
	{
		public Vec(int arity, Func<IEnumerable<bool>, bool> func) : base(arity, func)
		{
		}
	}

}
