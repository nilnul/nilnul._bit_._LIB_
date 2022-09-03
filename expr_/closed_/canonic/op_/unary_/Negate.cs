using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.poll.minterm.set_.sameVars.canonical.convert_
{
	/// <summary>
	/// !Sigma(m0, m2,m3) = Sigma(m1)
	/// in that:
	/// ! Sigma(m0, m2,m3)
	///	= Pi(!mo, !m2, !m3)
	///	= Pi (Sigma( m1,m2,m3), Sigma(m0,m1,m3), Sigma(m0,m1,m3)   )
	/// </summary>
	public class Neg : ConvertI
	{

		///returns the complement of the minterms
		public CanonicalI op(CanonicalI par)
		{
			throw new NotImplementedException();
		}
	}
}
