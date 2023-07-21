using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr._untyped.sys.be_
{
	public class OfBool :


		nilnul.obj.BeI1<System.Linq.Expressions.Expression>
		,
		nilnul.obj._expr._untyped.sys.BeI
	{
		public bool be(Expression obj)
		{
			if (obj is s.LambdaExpression)
			{
				return false;
			}
			return obj.Type == typeof(bool);
			///throw new NotImplementedException();
		}

		static public OfBool Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OfBool>.Instance;
			}
		}

	}
}
