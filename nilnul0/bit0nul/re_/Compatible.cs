using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit0nul.re_
{
	public class Compatible : ReI

	{
		public bool re(bool? a, bool? b)
		{
			return a is null || b is null || a.Value == b.Value;
		}

		public bool re(int a, int b)
		{
			
			return a ==0 || b ==0  || a == b;
		}

		static public Compatible Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Compatible>.Unison;
			}
		}

	}
}
