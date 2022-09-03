using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.bit.ExprI1;

namespace nilnul.bit.expr.vow_
{
	public class NotTauto:nilnul.obj.VowI<nilnul.bit.ExprI1>
	{



		

		public void vow(E obj)
		{
			nilnul.bit.expr.be_.tauto.anto.Vow.Singleton.vow(obj);
			//throw new NotImplementedException();
		}


		static public readonly NotTauto Singleton = nilnul.obj.SingletonByDefault<NotTauto>.Instance;

	}
}
