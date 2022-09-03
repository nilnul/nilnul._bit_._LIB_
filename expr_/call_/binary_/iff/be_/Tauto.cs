using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.call_.binary_.iff.be_
{
	public class Tauto:iff.BeI
	{
		
		

		public bool be(Iff_sys obj)
		{

			return nilnul.bit.expr.be_.Tauto_sys.Singleton.be(obj);
			//throw new NotImplementedException();
		}


		static public Tauto Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Tauto>.Instance;
			}
		}

	}
}
