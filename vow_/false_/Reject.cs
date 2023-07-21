using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit
{
	public partial class Reject
	{


     
		static public void Eval(bool x) {
			if (x)
			{
				throw new Exception("Assert true fails.");
				
				
			}
		}

	

		
	}
}
