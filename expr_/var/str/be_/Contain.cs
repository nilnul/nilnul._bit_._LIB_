using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.var.str.be_
{
	public class Contain : 
		nilnul.obj.str.be_.Contain<nilnul.bit.VarI1, nilnul.bit.var.StrI1>,
		
		nilnul.bit.var.str.BeI
	{
		

		public Contain(nilnul.bit.VarI1 var):base(nilnul.bit.var.Eq.Singleton, var)
		{
		}



	
	}
}
