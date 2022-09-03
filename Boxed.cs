using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public class Boxed : nilnul.obj.Box1<bool>
	{
		public Boxed(bool val) : base(val)
		{
		}
	}
}
