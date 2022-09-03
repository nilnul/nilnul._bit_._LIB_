using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.be.op
{
	public class Complement
	{

		static public Be<T> Eval<T>(Be<T> be)
		{
			return new _be.Be_froDualFunc<T>(be.func);
		}


		public partial class Expr<T, TBe>
	: nilnul.bit.Be_froDualFunc<T>
	where TBe : BeI<T>
		{
			public Expr(TBe beClass)
				: base(beClass.be)
			{

			}

		}
		public partial class Expr_TBeDefault<T, TBe>
			: Expr<T,TBe>
			where TBe : BeI<T>, new()
		{
			public Expr_TBeDefault()
				: base(SingletonByDefaultNew<TBe>.Instance)
			{

			}

		}

		public partial class Expr<T>
	: Expr<T,BeI<T>>
		{
			public Expr(BeI<T> be)
				: base(be)
			{

			}

		}


	}
}
