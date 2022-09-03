using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.unary_.not.recur_.truthy
{
	public class Slider
		: nilnul.obj.op_.unary.recur.slider_.RecurDefault<bool, unary_.Not1, Truthy>
	{
		


		static public Slider Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Slider>.Instance;
			}
		}

	}
}
