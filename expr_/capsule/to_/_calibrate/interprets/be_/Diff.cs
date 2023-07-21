using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr.interprets.be_
{
	public class Diff :
		nilnul.objs.be_.Diff<Interpretation, interpret.Eq >
		 
	{

		static public readonly Diff Singleton = SingletonByDefault<Diff>.Instance;


	}
}
