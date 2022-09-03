using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var
{
	public abstract class StrA : nilnul.bit.var.StrI
	{
		public abstract IEnumerator<VarI1> GetEnumerator();

		

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}



}
