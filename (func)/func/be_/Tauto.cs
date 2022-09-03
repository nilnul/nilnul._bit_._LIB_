using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func.be_
{
	/// <summary>
	/// the expression of the funcis tauto.
	/// </summary>
	public class Tauto : nilnul.bit.func.BeI1
	{

		public bool be(FuncI2 obj)
		{
			return nilnul.bit.expr_.plain.be_.Tauto.Singleton.be(obj.expr);
		}


		static public Tauto Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Tauto>.Instance;
			}
		}
	}
}
