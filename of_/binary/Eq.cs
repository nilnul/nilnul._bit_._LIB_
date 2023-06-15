using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.binary
{
	/// <summary>
	/// just view its truth table.
	/// </summary>
	public class Eq : IEqualityComparer<nilnul.bit.op_.BinaryI1>
	{
		


		static public readonly Eq Singleton = nilnul.obj.SingletonByDefault<Eq>.Instance;

		public bool Equals(BinaryI1 x, BinaryI1 y)
		{
			return op_.binary.re_.poset_._LinearX.LinearByResult(x) == op_.binary.re_.poset_._LinearX.LinearByResult(y);


		}

		public int GetHashCode(BinaryI1 obj)
		{
			return op_.binary.re_.poset_._LinearX.LinearByResult(obj) ;
		}
	}
}
