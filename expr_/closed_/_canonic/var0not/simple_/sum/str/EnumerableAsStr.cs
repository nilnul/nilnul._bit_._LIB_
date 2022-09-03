using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati.simple.str.op;

namespace nilnul.bit.expr.stati.simpleSum.str
{
	public class EnumerableAsStr
		:
		nilnul.seq.EnumerableA<Disjunct.Call>,
		StrI
	{
		private IEnumerable<Disjunct.Call> _call;

		public IEnumerable<Disjunct.Call> call
		{
			get { return _call; }
			set { _call = value; }
		}

		public EnumerableAsStr(IEnumerable<Disjunct.Call> val)
		{
			_call = val;
		}
  
		public override IEnumerator<Disjunct.Call> GetEnumerator()
		{
			return _call.GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
