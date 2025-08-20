using nilnul.bit.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine_
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class Gt
	{
		static public readonly Gt Singleton1 = SingletonByDefault<Gt>.Instance;


		static public bool Eval(bool x, bool y)
		{
			return !(Le.Eval(x, y));
		}
		
				

		public bool exec(bool a, bool b)
		{
			return Eval(a, b);
		}


		

		public bool eval(bool x, bool y)
		{
			return Eval(x, y);
			throw new NotImplementedException();
		}
		public const char Unicode = '\u219b';	//↛

	}

}
