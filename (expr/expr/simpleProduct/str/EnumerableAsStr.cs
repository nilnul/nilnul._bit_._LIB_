using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati.simple.str.op;

namespace nilnul.bit.expr.simpleProduct.str
{
	public class EnumerableAsStr
		:
		nilnul.seq.EnumerableA<nilnul.bit.expr.simple.str.op.Conjunct.Call>,
		StrI
	{
		private IEnumerable<nilnul.bit.expr.simple.str.op.Conjunct.Call> _call;

		public IEnumerable<nilnul.bit.expr.simple.str.op.Conjunct.Call> call
		{
			get { return _call; }
			set { _call = value; }
		}

		public EnumerableAsStr(IEnumerable<nilnul.bit.expr.simple.str.op.Conjunct.Call> val)
		{
			_call = val;
		}

		public EnumerableAsStr(IEnumerable<simple.set.op.Conjunct.Call> simpleSums)
	: this(simpleSums.Select(x => new simple.str.op.Conjunct.Call(x.arg)))
		{

		}


		public override IEnumerator<nilnul.bit.expr.simple.str.op.Conjunct.Call> GetEnumerator()
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
