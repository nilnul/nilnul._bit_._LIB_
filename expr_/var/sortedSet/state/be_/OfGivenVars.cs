using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.sortedSet.state.be_
{
	public class OfGivenVars : BeI
	{
		private nilnul.bit.var.SortedSet _vars;

		public nilnul.bit.var.SortedSet vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public OfGivenVars(nilnul.bit.var.SortedSet vars)
		{
			_vars = vars;
		}
		public bool be(nilnul.bit.var.sortedSet.State obj)
		{
			return nilnul.bit.var.sortedSet.Eq.Lazy._equals(
				obj.Keys, _vars	
			);

			//throw new NotImplementedException();
		}
	}
}
