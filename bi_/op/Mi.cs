using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.duo.op
{
	public partial class Mi
		:bit.duo.OpI,bit.duo.OpI1
	{

		static private readonly Mi _Instance = new Mi();
		static public Mi Instance
		{
			get
			{
				return _Instance;
			}
		}
		[Obsolete()]
		private Mi()
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
