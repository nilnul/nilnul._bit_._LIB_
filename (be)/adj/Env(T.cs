using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.adj
{
	public partial class Env<T>
	{

		public class Adj
		{

			public partial class FroAntonym
		: AdjI<T>
			{
				private AdjI<T> _adj;

				public AdjI<T> adj
				{
					get { return _adj; }
					set { _adj = value; }
				}

				public FroAntonym(AdjI<T> adj)
				{
					this._adj = adj;

				}
				public bool be(T val)
				{
					return !adj.be(val);
				}
			}

			public partial class FroFunc<T>
		: AdjI<T>
			{
				private Func<T, bool> _func;

				public Func<T, bool> notNullFunc
				{
					get { return _func; }
					set { _func = value; }
				}

				public Func<T, bool> func
				{
					get
					{
						return _func;
					}
					set
					{
						_func = value.EnsureNotNull();
					}
				}


				public FroFunc(NotNull2<Func<T, bool>> notNullFunc)
				{
					this.notNullFunc = notNullFunc;
				}

				public FroFunc(Func<T, bool> func)
					: this(func.ToNotNull())
				{
				}



				public bool be(T val)
				{
					return func(val);
				}

				public bool not(T val)
				{
					return !be(val);
				}
				public void assert(T val)
				{
					nilnul.bit.AssertionNullaryFunc.Assert(be(val));
				}
				public void disavow(T val)
				{
					nilnul.bit.AssertionNullaryFunc.Assert(not(val));
				}

				public bool be(NotNull2<T> val)
				{
					throw new NotImplementedException();
				}
			}
		}







	}
}
