using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.of_.vec
{
	/// <summary>
	/// just view its truth table.
	/// </summary>
	public class Comp : IComparer<nilnul.bit.op_.of_.VecI>
	{

		static public int OrdByTruthTableResult(op_.of_.VecI op)
		{
			return bit.str.op_.to_._AsRadixX.AsRadix(

				of_.vec._TruthTableX.LastCol(op)
			 );

		}

		public int Compare(VecI x, VecI y)
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
