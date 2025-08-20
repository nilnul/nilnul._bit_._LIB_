using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	[Obsolete()]
	public abstract class StrA : StrI
	{

		public abstract IEnumerator<bool> GetEnumerator()
		;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
	[Obsolete()]
	public interface StrI:IEnumerable<bool>,nilnul.StrI<bool>
	{

	}
}
