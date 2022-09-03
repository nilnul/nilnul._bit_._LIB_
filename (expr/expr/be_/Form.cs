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
	public class Form:

		nilnul.bit.expr.BeI1
	{
		 public bool be(nilnul.bit.ExprI3 expr)
		{
			return (expr ).vars.Count==0;
		}


		static public Form Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Form>.Instance;
			}
		}



	}


}
