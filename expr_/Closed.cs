using nilnul.obj;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_
{
	public interface ClosedI
		:nilnul.obj.expr_.typed_.generi_.ClosedI<bool>
		,
		bit.ExprI_generi
	{
	}

	public class Closed
		: nilnul.obj.expr_.typed_.generi_.Closed<bool>
		,
		nilnul.bit.ExprI_generi
		,
		ClosedI
	{
		public Closed(GeneriI<bool> val) : base(val)
		{
		}

		public Closed(Expr4 expr4):this(new Generi<bool>(expr4) )
		{
		}
	}
}
