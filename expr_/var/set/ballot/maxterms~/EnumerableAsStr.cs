using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.simple.set.op;
using nilnul.bit.expr.stati.simple.str.op;

namespace nilnul.bit.expr.simpleSum.str
{
	public class EnumerableAsStr
		:
		nilnul.seq.EnumerableA<expr.simple.str.op.Disjunct.Call>,
		StrI
	{
		private IEnumerable<expr.simple.str.op.Disjunct.Call> _call;

		public IEnumerable<expr.simple.str.op.Disjunct.Call> call
		{
			get { return _call; }
			set { _call = value; }
		}

		public EnumerableAsStr(IEnumerable<expr.simple.str.op.Disjunct.Call> val)
		{
			_call = val;
		}

		public EnumerableAsStr(IEnumerable<simple.set.op.Disjunct.Call> simpleSums)
			:this(simpleSums.Select(x=>new simple.str.op.Disjunct.Call(x.arg) ))
		{
			
		}

		public override IEnumerator<expr.simple.str.op.Disjunct.Call> GetEnumerator()
		{
			return _call.GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
