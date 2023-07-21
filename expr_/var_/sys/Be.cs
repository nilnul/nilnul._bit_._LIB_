using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_._var.sys
{
	public class Be : nilnul.obj.BeI1<ParameterExpression>
	{
		public bool be(ParameterExpression obj)
		{
			return obj.Type==typeof(bool);
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
