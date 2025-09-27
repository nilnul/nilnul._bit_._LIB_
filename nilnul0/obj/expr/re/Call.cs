using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.re
{
	public class Call<T, TExpr, TRe>
		:
		nilnul.obj.Co<TExpr>
		,
		_call_.ReI<T,TRe>
		,
		nilnul.bit.IExpr

		where TExpr : nilnul.obj.ExprI3<T>
		where TRe: nilnul.obj.ReI<T>

	{
		public Call(TRe re, Tuple<TExpr, TExpr> tuple) : base(tuple)
		{
			_re = re;
		}

		public Call(TRe re,(TExpr, TExpr) valTuple) : base(valTuple)
		{
				_re = re;
	}

		public Call(TRe re,TExpr item1, TExpr item2) : base(item1, item2)
		{
				_re = re;
	}

		private TRe _re;

		public TRe re => _re;
	}

	public class Call<T>
		:
		Call<T, nilnul.obj.ExprI3<T>, nilnul.obj.ReI<T>>
	{
		public Call(ReI<T> re, Tuple<ExprI3<T>, ExprI3<T>> tuple) : base(re, tuple)
		{
		}

		public Call(ReI<T> re, (ExprI3<T>, ExprI3<T>) valTuple) : base(re, valTuple)
		{
		}

		public Call(ReI<T> re, ExprI3<T> item1, ExprI3<T> item2) : base(re, item1, item2)
		{
		}
	}

}
