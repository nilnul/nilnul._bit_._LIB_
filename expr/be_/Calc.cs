using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.be_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///alias:
	///	calc: the expr is calculation/calculable
	/// </remarks>
	public class Calc:
		//nilnul.obj.expr.be_.

		nilnul.bit.expr.BeI2
	{
		 public bool be(nilnul.bit.ExprI_generi expr)
		{
			return nilnul.obj.expr.be_.Calc.Singleton.be(expr);

			//return (expr ).vars.Count==0;
		}


		static public Calc Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Calc>.Instance;
			}
		}



	}


}
