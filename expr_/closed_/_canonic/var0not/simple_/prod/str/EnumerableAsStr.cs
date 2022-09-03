using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati.simple.str.op;

namespace nilnul.bit.expr.stati.simpleProduct.str
{
	public class EnumerableAsStr
		:
		nilnul.seq.EnumerableA<Conjunct.Call>,
		StrI
	{
		private IEnumerable<Conjunct.Call> _call;

		public IEnumerable<Conjunct.Call> call
		{
			get { return _call; }
			set { _call = value; }
		}

		public EnumerableAsStr(IEnumerable<Conjunct.Call> val)
		{
			_call = val;
		}
  
		public override IEnumerator<Conjunct.Call> GetEnumerator()
		{
			return _call.GetEnumerator();
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return $"{nilnul.CollectionTostrX.Tostr(_call)}";
		}
	}
}
