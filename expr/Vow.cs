using nilnul.bit._expr_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr
{
	public interface VowI: nilnul.obj.VowI2<nilnul.bit.ExprI_sys>
	{
	}

	public abstract class VowA : VowI
	{
		public abstract void vow(ExprI_sys obj);
		public void vow(Expr_sys x) {
			vow((ExprI_sys)x);
		}

	}
}
