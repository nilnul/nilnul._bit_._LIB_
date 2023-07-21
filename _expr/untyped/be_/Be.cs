using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;
using nilnul.obj._expr;

namespace nilnul.bit._expr.untyped
{
	public class Be :


		nilnul.obj._expr.untyped.BeI
	{

		public bool be(UntypedI obj)
		{
			return obj.lambda.ee.Type == typeof(bool);

		}
		public bool be(Untyped obj)
		{
			return be((UntypedI)obj);

		}

		public bool be(Expression obj)
		{
			return be(new Untyped(obj) );
		}

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
