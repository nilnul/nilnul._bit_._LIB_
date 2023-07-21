using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati.be;

namespace nilnul.bit.expr.stati.simple.str
{
	public class Empty : StrI
	{
		public IEnumerator<Simple.Asserted> GetEnumerator()
		{
			yield break;
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
