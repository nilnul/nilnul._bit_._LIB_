using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit._proof
{
	/// <summary>
	/// a collection of expr (not always tautology) that is asserted true.
	/// </summary>
	public class Presumtion
	{
		private IEnumerable<ExprI1> _axioms;
		public IEnumerable<E> axioms {
			get { return _axioms; }
		}

	}
}
