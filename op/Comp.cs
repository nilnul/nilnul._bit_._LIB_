using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.of_.vec
{
	/// <summary>
	/// just view its truth table.
	/// </summary>
	public class Comp : IComparer<nilnul.bit.of_.ScalaI>
	{

		static public int OrdByTruthTableResult(of_.ScalaI op)
		{
			return bit.str.op_.to_._AsRadixX.AsRadix(

				of_.vec._TruthTableX.LastCol(op)
			 );

		}

		public int Compare(ScalaI x, ScalaI y)
		{
			if (x.arity == y.arity)
			{
				// note: 0 for different arity shall be compared
				return OrdByTruthTableResult(x) - OrdByTruthTableResult(y);

			}
			return x.arity.CompareTo(y.arity);


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
