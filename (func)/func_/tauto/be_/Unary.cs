using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.func_.tauto.be_
{
	public class Unary : nilnul.bit.func_.tauto.BeI
	{
		public bool be(TautoI obj)
		{
			return obj.tauto.en.pars.en.Count() == 1;
			throw new NotImplementedException();
		}

		static public Unary Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Unary>.Instance;
			}
		}

	}
}
