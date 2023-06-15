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
	public class Eq :
		IEqualityComparer<nilnul.bit.op_.of_.VecI>
	{
		



	

		public bool Equals(VecI x, VecI y)
		{
			if (x.arity!=y.arity)
			{
				return false;
			}

			return nilnul.bit.vec.Eq.Singleton.Equals(
				 op_.of_.vec._TruthTableX.LastCol(x)
				 ,
				 op_.of_.vec._TruthTableX.LastCol(y)

			);


		}


		public int GetHashCode(VecI obj)
		{
			return 0;

		}
	}
}
