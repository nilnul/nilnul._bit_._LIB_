using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.str_.enumable.op_.pair_
{

	static public class _AndX
	{
		static public IEnumerable<bool> Op(IEnumerable<bool> bits)
		{

			if (nilnul.objs.be_._NoneX.None( bits))
			{
				yield break;
			}

			var enumerator = bits.GetEnumerator();
			enumerator.MoveNext();

			var prev = enumerator.Current;

			while (enumerator.MoveNext())
			{
				yield return prev && enumerator.Current;
				prev = enumerator.Current;
			}

		}

	}
	public class And : OpI
	{
		public EnumableI op(EnumableI bits)
		{
			return new Enumable( _AndX.Op(bits) );
			//throw new NotImplementedException();
		}


		public IEnumerable<bool> op(IEnumerable<bool> bits) {
			return _AndX.Op(bits);
		}
		static public And Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<And>.Instance;
			}
		}

	}
}
