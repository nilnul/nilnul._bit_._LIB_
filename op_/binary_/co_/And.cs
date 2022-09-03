using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.combine_
{
	public partial class And
		:bit.CombineI
	{

		static private readonly And _Instance = new And();
		static public And Instance
		{
			get
			{
				return _Instance;
			}
		}
		[Obsolete()]
		private And()
		{
		}

		


		static public bool Eval(bool a, bool b)
		{
			return a && b;

		}
		public bool exec(bool operand1, bool operand2)
		{
			return operand1 && operand2;
		}

		public bool eval(bool x, bool y)
		{
			return x && y;
			throw new NotImplementedException();
		}


		public override string ToString()
		{
			return "&";
		}

	}

}
