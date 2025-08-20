using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit
{
	public  class Combine
		: nilnul.obj.duo.op.Closed<bool>, CombineI
	{
		public Combine(Func<bool,bool,bool> func)
			:base(func)
		{

		}
		
	}
	
	public interface CombineI
		:
		nilnul.obj.CombineI<bool>
	{


	}


}
