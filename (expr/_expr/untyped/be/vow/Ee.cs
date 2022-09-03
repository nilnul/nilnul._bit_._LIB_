using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit._expr.untyped.be.vow
{
	public class Ee : nilnul.obj.vow.ee_.Defaultable<obj._expr.UntypedI, Vow>
	{
		public Ee(obj._expr.UntypedI val) : base(val)
		{
		}
		public Ee(obj._expr.Untyped val) : base(val)
		{
		}

		public Ee(Expression val) : this(new obj._expr.Untyped(val) )
		{
		}

	}
}
