using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.duo.op
{
	public sealed class Add
	{

		static public Duo Eval(bool x, bool y) {


			return new Duo(x&&y, x==y );
		}


		

	
	}
}
