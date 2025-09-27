using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.re._call_
{
	public interface ReI<T, TRe>
		where TRe: nilnul.obj.ReI<T>
	{
		TRe re { get; }
	}

	public interface ReI<T>
		: ReI<T, obj.ReI<T>>
	{ }

	public abstract class ReA<T, TRe>
		:
		ReI<T, TRe>
		where TRe : nilnul.obj.ReI<T>


	{
		public ReA(TRe re)
		{
			_re = re;
		}
		private TRe _re;
		public TRe re => _re;
	}

	public abstract class ReA<T>
		: ReA<T, obj.ReI<T>>
	{
		protected ReA(obj.ReI<T> re) : base(re)
		{
		}
	}

}
