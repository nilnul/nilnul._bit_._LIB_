using nilnul.bit.expr.stati.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using nilnul.str;

namespace nilnul.bit.expr.simple
{
	public class Str
		:
		nilnul.Box<IEnumerable<expr.be.Simple.Asserted>>,
		bit.expr.simple.StrI
	{
		public IEnumerator<expr.be.Simple.Asserted> GetEnumerator()
		{
			foreach (var item in this.val)
			{
				yield return item;

			}
			
		}

		public Str(IEnumerable<expr.be.Simple.Asserted> v):base(v)
		{

		}

		public override string ToString()
		{
			return val.ToTxt();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
	public interface StrI:IEnumerable<expr.be.Simple.Asserted>
	{



	}
}
