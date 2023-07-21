using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr.untyped
{
	public interface BeI : nilnul.obj._expr.un<System.Linq.Expressions.Expression>
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

		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
