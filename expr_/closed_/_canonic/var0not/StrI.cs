using nilnul.bit.expr.stati.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nilnul.bit.expr.stati.simple
{
	public class Str
		:
		nilnul.Box<IEnumerable<Simple.Asserted>>,
		StrI
	{
		public IEnumerator<Simple.Asserted> GetEnumerator()
		{
			foreach (var item in this.val)
			{
				yield return item;

			}
			
		}

		public Str(IEnumerable<Simple.Asserted> v):base(v)
		{

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
	public interface StrI:IEnumerable<Simple.Asserted>
	{



	}
}
