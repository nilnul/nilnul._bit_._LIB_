using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op.unary
{
	public partial class Not
		:UnaryI
	{

		static public Not Singleton = SingletonByDefault<Not>.Instance;

		public bool exec(bool operand)
		{
			return !operand;
		}



		public bool eval(bool arg)
		{
			return !arg;
			throw new NotImplementedException();
		}
	}
}
