using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.bit.no.op
{
	public class On:Constant
	{
		static public On Singleton = SingletonByDefault<On>.Instance;


		public On():base(true)
		{
		}
	}
	public class No:Constant

	{

		static public No Singleton = SingletonByDefault<No>.Instance;
		public No():base(false)
		{
		}
	}
}
