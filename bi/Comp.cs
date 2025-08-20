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
	public class Comp : IComparer<nilnul.bit.op_.BinaryI1>
	{
		

		public int Compare(BinaryI1 x, BinaryI1 y)
		{
			return op_.binary.re_.poset_._LinearX.LinearByResult(x) - op_.binary.re_.poset_._LinearX.LinearByResult(y);

		}

		static public Comp Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Comp>.Instance;
			}
		}

	}
}
