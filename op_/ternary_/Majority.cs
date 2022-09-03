using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.op_.ternary_
{
	public class Majority:
		TernaryA,
		TernaryI
	{
		//public bool dual(bool x1, bool y,  bool z) {
		//	return x1 == y ? z : y;
		//}

		public override bool op(bool x, bool y,  bool z) {
			return x == y ? y : z;
		}


		static public Majority Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Majority>.Instance;
			}
		}


	}
}
